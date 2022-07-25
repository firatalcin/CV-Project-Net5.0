using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PortfolioManager : GenericManager<Portfolio>, IPortfolioService
    {
        public PortfolioManager(IGenericRepository<Portfolio> repository) : base(repository)
        {
        }
    }
}