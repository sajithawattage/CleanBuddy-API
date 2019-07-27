using Autofac;
using Autofac.Integration.WebApi;
using Cleaner.Business.Config;
using Cleaner.DataAccess.Infrastructure;
using Cleaner.DataAccess.UnitOfWork;
using System.Reflection;
using System.Web.Http;

namespace Cleaner.API.Dependency
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterApiControllers(assembly);
            ServiceConfig.RegisterServices(builder);

            builder.RegisterType<CDbContext>().As<CDbContext>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            Container = builder.Build();
            return Container;
        }
    }
}