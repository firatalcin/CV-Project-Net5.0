using CoreCV_Project.BusinessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void TAdd(Contact entity)
        {
           _contactDal.Add(entity);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TRemove(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity); 
        }
    }
}
