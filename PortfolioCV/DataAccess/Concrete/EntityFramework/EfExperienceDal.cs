using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal
    {
        public EfExperienceDal(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}