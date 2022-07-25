using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FeatureManager : GenericManager<Feature>, IFeatureService
    {
        public FeatureManager(IGenericRepository<Feature> repository) : base(repository)
        {
        }
    }
}