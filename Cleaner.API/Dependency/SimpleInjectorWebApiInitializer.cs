using Cleaner.Business;
using Cleaner.DataAccess.Repositories;
using Cleaner.DataAccess.Infrastructure;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;

namespace Cleaner.API.Dependency
{
    public class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize(IAppBuilder app)
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            InitializeContainer(container);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            //allow scoped instances to be resolved during an OWIN request
            app.Use(async (context, next) => {
                using (AsyncScopedLifestyle.BeginScope(container))
                {
                    await next();
                }
            });
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<IConnectionFactory, ConnectionFactory>(Lifestyle.Singleton);

            container.Register<IAddressService, AddressService>(Lifestyle.Scoped);
            container.Register<IApproveGroupService, ApproveGroupService>(Lifestyle.Scoped);
            container.Register<IApproveGroupUserService, ApproveGroupUserService>(Lifestyle.Scoped);
            container.Register<IContractorService, ContractorService>(Lifestyle.Scoped);
            container.Register<IEmployeeService, EmployeeService>(Lifestyle.Scoped);
            container.Register<IEquipmentCategoryService, EquipmentCategoryService>(Lifestyle.Scoped);
            container.Register<IEquipmentService, EquipmentService>(Lifestyle.Scoped);
            container.Register<IJobEquipmentService, JobEquipmentService>(Lifestyle.Scoped);
            container.Register<IJobService, JobService>(Lifestyle.Scoped);
            container.Register<IUserLoginService, UserLoginService>(Lifestyle.Scoped);
            
        }

    }
}