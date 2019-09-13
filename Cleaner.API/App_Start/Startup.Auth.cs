using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using Cleaner.API.Authentication;
using Microsoft.Owin.Cors;

namespace Cleaner.API
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; set; }

        public static string PublicClientId { get; private set; }
        
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseCors(CorsOptions.AllowAll);
            
            // Configure the application for OAuth based flow
            PublicClientId = "self";
            
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/v1/token"),
                Provider = new AuthenticationProvider(PublicClientId),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);
        }

    }
}