using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Integration.Web;
using System.Reflection;
using DBContextHelper;
using JDEContext;
using EPMContext;
using OAContext;

namespace OA
{
    public class Global : System.Web.HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            InitIoC();
        }

        private static void InitIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(t => 1 == 1).AsImplementedInterfaces();

            var services = Assembly.Load("OAContext");
            builder.RegisterAssemblyTypes(services).Where(t => 1 == 1).AsImplementedInterfaces();

            var services2 = Assembly.Load("OA.Service");
            builder.RegisterAssemblyTypes(services2).Where(t => 1 == 1).AsImplementedInterfaces();

            var services3 = Assembly.Load("OA");
            builder.RegisterAssemblyTypes(services3).Where(t => 1 == 1).AsImplementedInterfaces();
            //builder.RegisterType<Log>().As<ILog>();

            // Once you're done registering things, set the container
            // provider up with your registrations.
            _containerProvider = new ContainerProvider(builder.Build());
        }
    }
}