using JetBrains.Space.AspNetCore.Authentication;
using JetBrains.Space.AspNetCore.Authentication.Experimental.TokenManagement;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JetBrains.Space.Samples.Web;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Razor
        services.AddRouting(options => options.LowercaseUrls = true);
        services.AddRazorPages();
            
        // Space authentication
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = SpaceDefaults.AuthenticationScheme;
            })
            .AddCookie()
            .AddSpace(options => Configuration.Bind("Space", options))
            .AddSpaceTokenManagement(); // auto-refreshes tokens in the background and provides a Space connection

        // - or: -
        // .AddSpace(options =>
        // {
        //     options.ServerUrl = new Uri(Configuration["Space:ServerUrl"]);
        //     options.ClientId = Configuration["Space:ClientId"];
        //     options.ClientSecret = Configuration["Space:ClientSecret"];
        //
        //     options.Scope.Add("**");
        //     options.AccessType = AccessType.Offline;
        //     options.SaveTokens = true;
        // });
            
        // Space client API
        services.AddSpaceClientApi();
            
        // CORS
        services.AddCors(setup =>
        {
            // ...for Space attachment proxy
            setup.AddPolicy("SpaceAttachmentProxy", _ => _
                .WithMethods("GET")
                .WithOrigins("http://localhost:5000", 
                    "https://localhost:5001"));
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseCors();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints
                .MapSpaceAttachmentProxy("/space-attachments")
                .RequireCors("SpaceAttachmentProxy");

            endpoints.MapRazorPages();
        });
    }
}