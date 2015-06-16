using Contacts.Container;
using Contacts.Entity;
using Contacts.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Contacts.Repository.Concrete
{
    public class PersonRepository
        : Repository<Person>, IPersonRepository
    {
        private readonly Expression<Func<Person, PersonContainer>> _projectionFunc_Person_PersonContainer = p => new PersonContainer
        {
            Id = p.Id,
            FirstName = p.FirstName,
            LastName = p.LastName
        };

        public PersonRepository(ContactsModel model)
            : base(model)
        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Container.PersonContainer>> GetAsync(System.Linq.Expressions.Expression<System.Func<Person, object>> sortingKeySelector, System.Data.SqlClient.SortOrder sortOrder, int pageIndex, int pageSize)
        {
            return await base
                .Get(sortingKeySelector, sortOrder, pageIndex, pageSize)
                .Select<Person, PersonContainer>(_projectionFunc_Person_PersonContainer)
                .ToListAsync<PersonContainer>();
        }

        public Task<PersonContainer> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
