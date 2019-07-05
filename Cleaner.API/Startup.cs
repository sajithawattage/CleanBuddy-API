using Cleaner.API.Dependency;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Cleaner.API.Startup))]

namespace Cleaner.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);

            //You don't need these lines if you are using bearer token as the token is 
            //passed in the request header and not in the cookie
            //app.UseCookieAuthentication(new CookieAuthenticationOptions());
            //app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                //TokenEndpointPath = new PathString("/Token"),
                //Provider = new ApplicationOAuthProvider(PublicClientKey),
                //AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                //AllowInsecureHttp = true
            };

            //Remove this part
            //app.UseOAuthBearerTokens(OAuthOptions);

            //And try to manually define the authorization server 
            //and the middleware to handle the tokens
            app.UseOAuthAuthorizationServer(OAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            //SimpleInjectorWebApiInitializer.Initialize(app);
            //ConfigureAuth(app);
        }
    }
}
