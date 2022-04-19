using CoreCV_Project.BusinessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service entity)
        {
            _serviceDal.Add(entity);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public List<Service> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TRemove(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
