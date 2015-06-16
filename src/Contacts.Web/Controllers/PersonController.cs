using Contacts.Container;
using Contacts.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.Http;

namespace Contacts.Web.Controllers
{
    [RoutePrefix("api/person")]
    [AllowAnonymous]
    public class PersonController : ApiController
    {
        private readonly IPersonRepository _repository;
        private const int _pageSize = 10;
        public PersonController(IPersonRepository personRepository)
        {
            _repository = personRepository;
        }

        // GET api/person
        public async Task<IEnumerable<PersonContainer>> Get(int index)
        {
            return await _repository
                .GetAsync(p => p.FirstName, SortOrder.Ascending, index, _pageSize);
        }

        public async Task<PersonContainer> Get(Guid id)
        {
            return await _repository.GetAsync(id);
        }
    }
}