using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Space.Common.Json.Serialization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Authentication.Experimental.TokenManagement;

/// <summary>
/// An implementation of <see cref="CookieAuthenticationEvents"/> to handle automatic authentication token refresh with a Space organization.
/// </summary>
/// <remarks>
/// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>.
/// </remarks>
[SuppressMessage("ReSharper", "LogMessageIsSentenceProblem")]
public class SpaceTokenManagementCookieEvents : CookieAuthenticationEvents
{
    private readonly SpaceTokenManagementOptions _options;
    private readonly IOptionsSnapshot<SpaceOptions> _spaceOptions;
    private readonly IAuthenticationSchemeProvider _schemeProvider;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger _logger;
    private readonly ISystemClock _clock;
        
    private static readonly ConcurrentDictionary<string, bool> PendingRefreshTokenRequests = new();

    /// <summary>
    /// Creates a new <see cref="SpaceTokenManagementCookieEvents"/> instance.
    /// </summary>
    /// <param name="options">The <see cref="SpaceTokenManagementOptions"/> used by the current <see cref="SpaceTokenManagementCookieEvents"/>.</param>
    /// <param name="spaceOptions">The <see cref="SpaceOptions"/> used by the current <see cref="SpaceTokenManagementCookieEvents"/>.</param>
    /// <param name="schemeProvider">An <see cref="IAuthenticationSchemeProvider"/> used by the current <see cref="SpaceTokenManagementCookieEvents"/>.</param>
    /// <param name="httpClientFactory">An <see cref="IHttpClientFactory"/> used by the current <see cref="SpaceTokenManagementCookieEvents"/>.</param>
    /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="SpaceTokenManagementCookieEvents"/>.</param>
    /// <param name="clock">An <see cref="ISystemClock"/> used by the current <see cref="SpaceTokenManagementCookieEvents"/>.</param>
    public SpaceTokenManagementCookieEvents(
        IOptions<SpaceTokenManagementOptions> options,
        IOptionsSnapshot<SpaceOptions> spaceOptions,
        IAuthenticationSchemeProvider schemeProvider,
        IHttpClientFactory httpClientFactory,
        ILogger<SpaceTokenManagementCookieEvents> logger,
        ISystemClock clock)
    {
        _options = options.Value;
        _spaceOptions = spaceOptions;
        _schemeProvider = schemeProvider;
        _httpClientFactory = httpClientFactory;
        _logger = logger;
        _clock = clock;
    }

    /// <inheritdoc />
    public override async Task ValidatePrincipal(CookieValidatePrincipalContext context)
    {
        var tokens = context.Properties.GetTokens().ToList();
        if (tokens.Count == 0)
        {
            _logger.LogDebug("No tokens found in cookie properties. SaveTokens must be enabled for automatic token refresh.");
            return;
        }

        var refreshToken = tokens.SingleOrDefault(t => t.Name == "refresh_token");
        if (refreshToken == null)
        {
            _logger.LogWarning("No refresh token found in cookie properties. A refresh token must be requested and SaveTokens must be enabled.");
            return;
        }

        var expiresAt = tokens.SingleOrDefault(t => t.Name == "expires_at");
        if (expiresAt == null)
        {
            _logger.LogWarning("No expires_at value found in cookie properties.");
            return;
        }

        var dtExpires = DateTimeOffset.Parse(expiresAt.Value, CultureInfo.InvariantCulture);
        var dtRefresh = dtExpires.Subtract(_options.RefreshBeforeExpiration);

        if (dtRefresh < _clock.UtcNow)
        {
            var shouldRefresh = PendingRefreshTokenRequests.TryAdd(refreshToken.Value, true);
            if (shouldRefresh)
            {
                try
                {
                    var spaceOptions = await GetSpaceOptionsAsync();
                        
                    var httpClient = _httpClientFactory.CreateClient();
                    var spaceTokenRequest = new HttpRequestMessage(HttpMethod.Post, spaceOptions.TokenEndpoint)
                    {
                        Headers =
                        {
                            Authorization = AuthenticationHeaderValue.Parse(
                                "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{spaceOptions.ClientId}:{spaceOptions.ClientSecret}")))
                        },
                        Content = new FormUrlEncodedContent(new []
                        {
                            new KeyValuePair<string?, string?>("grant_type", "refresh_token"),
                            new KeyValuePair<string?, string?>("refresh_token", refreshToken.Value),
                            new KeyValuePair<string?, string?>("scope", string.Join(" ", spaceOptions.Scope))
                        })
                    };

                    var spaceTokenResponse = await httpClient.SendAsync(spaceTokenRequest);
                    if (!spaceTokenResponse.IsSuccessStatusCode)
                    {
                        _logger.LogWarning("Error refreshing token: {StatusCode} {Message}", spaceTokenResponse.StatusCode, spaceTokenResponse.ReasonPhrase);

                        context.RejectPrincipal();
                        return;
                    }
                        
                    using var spaceTokenDocument = await JsonDocument.ParseAsync(await spaceTokenResponse.Content.ReadAsStreamAsync());
                    var spaceToken = spaceTokenDocument.RootElement;

                    context.Properties.UpdateTokenValue("access_token",  spaceToken.GetStringValue("access_token")!);
                    context.Properties.UpdateTokenValue("refresh_token", spaceToken.GetStringValue("refresh_token") ?? refreshToken.Value);

                    var newExpiresAt = DateTime.UtcNow + TimeSpan.FromSeconds(spaceToken.GetInt32Value("expires_in"));
                    context.Properties.UpdateTokenValue("expires_at", newExpiresAt.ToString("o", CultureInfo.InvariantCulture));

                    await context.HttpContext.SignInAsync(context.Principal!, context.Properties);
                }
                finally
                {
                    PendingRefreshTokenRequests.TryRemove(refreshToken.Value, out _);
                }
            }
        }
    }
        
    private async Task<SpaceOptions> GetSpaceOptionsAsync()
    {
        if (string.IsNullOrEmpty(_options.Scheme))
        {
            var scheme = await _schemeProvider.GetDefaultChallengeSchemeAsync();
            return _spaceOptions.Get(scheme?.Name);
        }

        return _spaceOptions.Get(_options.Scheme);
    }
}