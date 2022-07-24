using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IServiceDal : IGenericRepository<Service>
    {
    }
}