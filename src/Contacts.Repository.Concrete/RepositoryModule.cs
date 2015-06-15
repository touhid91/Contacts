using Autofac;

namespace Contacts.Repository.Concrete
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(Contacts.Repository.Abstract.IRepository<>))
                .WithParameter("context", new Contacts.Entity.ContactsModel())
                .InstancePerRequest();
        }
    }
}
