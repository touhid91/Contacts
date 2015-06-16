using Contacts.Entity;
using Contacts.Repository.Abstract;
using Contacts.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Contacts.Repository.UnitTest
{
    [TestClass]
    public class PersonRepositoryTest
    {
        [TestMethod]
        public async Task GetAsync_IsEqualToCount_Always()
        {
            IPersonRepository _repository = new PersonRepository(new ContactsModel());

            int personCount = await _repository.CountAsync();
            System.Collections.Generic.ICollection<Contacts.Container.PersonContainer> personDetails = await _repository.GetAsync(p => p.LastName, SortOrder.Ascending, 1, 10);

            Assert.AreEqual(personCount, personDetails.Count);
        }
    }
}
