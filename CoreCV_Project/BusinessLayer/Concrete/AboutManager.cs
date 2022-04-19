using CoreCV_Project.BusinessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCV_Project.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public About TGetById(int id)
        {
           return _aboutDal.GetById(id);
        }

        public void TRemove(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
