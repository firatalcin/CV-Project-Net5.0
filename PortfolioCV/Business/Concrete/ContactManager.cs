using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        public ContactManager(IGenericRepository<Contact> repository) : base(repository)
        {
        }
    }
}