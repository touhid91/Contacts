using Contacts.Container;
using Contacts.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Contacts.Repository.Abstract
{
    public interface IPersonRepository
        : IRepository<Person>
    {
        Task<ICollection<PersonContainer>> GetAsync(Expression<Func<Person, object>> sortingKeySelector, SortOrder sortOrder, int pageIndex, int pageSize);
    }
}
