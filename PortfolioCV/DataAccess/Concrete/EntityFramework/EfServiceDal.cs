using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}