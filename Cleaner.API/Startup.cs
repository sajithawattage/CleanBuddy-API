using Cleaner.API.Dependency;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Cleaner.API.Startup))]

namespace Cleaner.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            SimpleInjectorWebApiInitializer.Initialize(app);
            ConfigureAuth(app);
        }
    }
}
