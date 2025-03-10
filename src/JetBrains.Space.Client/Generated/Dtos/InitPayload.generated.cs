// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class InitPayload
     : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "InitPayload";
    
    public InitPayload() { }
    
    public InitPayload(string clientSecret, string serverUrl, string clientId, string userId, string? state = null, string? verificationToken = null)
    {
        ClientSecret = clientSecret;
        ServerUrl = serverUrl;
        State = state;
        ClientId = clientId;
        UserId = userId;
        VerificationToken = verificationToken;
    }
    
    private PropertyValue<string> _clientSecret = new PropertyValue<string>(nameof(InitPayload), nameof(ClientSecret));
    
    [Required]
    [JsonPropertyName("clientSecret")]
    public string ClientSecret
    {
        get => _clientSecret.GetValue();
        set => _clientSecret.SetValue(value);
    }

    private PropertyValue<string> _serverUrl = new PropertyValue<string>(nameof(InitPayload), nameof(ServerUrl));
    
    [Required]
    [JsonPropertyName("serverUrl")]
    public string ServerUrl
    {
        get => _serverUrl.GetValue();
        set => _serverUrl.SetValue(value);
    }

    private PropertyValue<string?> _state = new PropertyValue<string?>(nameof(InitPayload), nameof(State));
    
    [JsonPropertyName("state")]
    public string? State
    {
        get => _state.GetValue();
        set => _state.SetValue(value);
    }

    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(InitPayload), nameof(ClientId));
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue();
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string> _userId = new PropertyValue<string>(nameof(InitPayload), nameof(UserId));
    
    [Required]
    [JsonPropertyName("userId")]
    public string UserId
    {
        get => _userId.GetValue();
        set => _userId.SetValue(value);
    }

    private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(InitPayload), nameof(VerificationToken));
    
    [JsonPropertyName("verificationToken")]
    public string? VerificationToken
    {
        get => _verificationToken.GetValue();
        set => _verificationToken.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _clientSecret.SetAccessPath(path, validateHasBeenSet);
        _serverUrl.SetAccessPath(path, validateHasBeenSet);
        _state.SetAccessPath(path, validateHasBeenSet);
        _clientId.SetAccessPath(path, validateHasBeenSet);
        _userId.SetAccessPath(path, validateHasBeenSet);
        _verificationToken.SetAccessPath(path, validateHasBeenSet);
    }

}

