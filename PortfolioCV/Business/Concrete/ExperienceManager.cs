using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ExperienceManager : GenericManager<Experience>, IExperienceService
    {
        public ExperienceManager(IGenericRepository<Experience> repository) : base(repository)
        {
        }
    }
}