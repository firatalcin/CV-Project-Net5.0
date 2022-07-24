using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPortfolio : GenericRepository<Portfolio>, IPortfolioDal
    {
        public EfPortfolio(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}