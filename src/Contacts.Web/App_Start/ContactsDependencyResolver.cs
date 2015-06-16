using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Contacts.Repository.Concrete;
using System.Reflection;

namespace Contacts.Web.App_Start
{
    public sealed class ContactsDependencyResolver
    {
        private static IContainer _container;
        static ContactsDependencyResolver()
        {
            if (_container == null)
            {
                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterModule(new RepositoryModule());
                builder.RegisterControllers(Assembly.GetExecutingAssembly());
                builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
                _container = builder.Build();
            }
        }

        public static ILifetimeScope GetLifetimeScope()
        {
            return _container;
        }
    }
}