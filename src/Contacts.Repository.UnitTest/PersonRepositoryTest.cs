using Contacts.Repository.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Contacts.Repository.UnitTest
{
    [TestClass]
    public class PersonRepositoryTest
    {
        private readonly IPersonRepository _repository;
        public PersonRepositoryTest()
        {
            _repository = DependencyResolver.Resolve<IPersonRepository>();
        }

        [TestMethod]
        public async Task GetAsync_IsEqualToCount_Always()
        {
            int personCount = await _repository.CountAsync();
            System.Collections.Generic.ICollection<Contacts.Container.PersonContainer> personDetails = await _repository.GetAsync(p => p.LastName, SortOrder.Ascending, 1, 10);
            Assert.AreEqual(personCount, personDetails.Count);
        }
    }
}
