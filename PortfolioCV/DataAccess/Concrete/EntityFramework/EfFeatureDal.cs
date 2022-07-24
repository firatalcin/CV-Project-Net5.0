using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}