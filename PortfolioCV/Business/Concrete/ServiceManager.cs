using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ServiceManager : GenericManager<Service>, IServiceService
    {
        public ServiceManager(IGenericRepository<Service> repository) : base(repository)
        {
        }
    }
}