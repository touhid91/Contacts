using Autofac;
using Contacts.Repository.Abstract;

namespace Contacts.Repository.Concrete
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<Contacts.Entity.ContactsModel>().AsSelf();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(Contacts.Repository.Abstract.IRepository<>));
            builder.RegisterType<PersonRepository>().As<IPersonRepository, IRepository<Contacts.Entity.Person>>();
        }
    }
}
