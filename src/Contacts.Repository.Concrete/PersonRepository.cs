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
        public PersonRepository(ContactsModel model)
            : base(model)
        {

        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Container.PersonContainer>> GetAsync(System.Linq.Expressions.Expression<System.Func<Person, object>> sortingKeySelector, System.Data.SqlClient.SortOrder sortOrder, int pageIndex, int pageSize)
        {
            Func<Person, PersonContainer> projectionFunc = p => new PersonContainer
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName
            };
            return await base
                .Get(sortingKeySelector, sortOrder, pageIndex, pageSize)
                .ToListAsync<Person>()
                .ContinueWith<ICollection<PersonContainer>>(t => t.Result.Select<Person, PersonContainer>(projectionFunc).ToList<PersonContainer>());
        }
    }
}
