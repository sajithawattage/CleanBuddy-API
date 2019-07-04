using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Business.Config
{
    public static class ServiceConfig
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                  .Where(t => t.Name.EndsWith("Service"))
                  .AsImplementedInterfaces();
           
        }
    }
}
