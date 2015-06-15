using Autofac;
using Contacts.Repository.Concrete;

namespace Contacts.Repository.UnitTest
{
    internal sealed class DependencyResolver
    {
        static readonly IContainer _container;
        static DependencyResolver()
        {
            if (_container == null)
            {
                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterModule(new RepositoryModule());
                _container = builder.Build();
            }
        }

        internal static TDependency Resolve<TDependency>()
        {
            return _container.Resolve<TDependency>();
        }
    }
}
