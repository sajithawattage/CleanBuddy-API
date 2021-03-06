﻿using Autofac;
using Autofac.Integration.WebApi;
using Cleaner.Business.Config;
using Cleaner.DataAccess;
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
            builder.RegisterType<KiaOraEntities>().As<KiaOraEntities>().InstancePerLifetimeScope();
            ServiceConfig.RegisterServices(builder);
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            Container = builder.Build();
            return Container;
        }
    }
}