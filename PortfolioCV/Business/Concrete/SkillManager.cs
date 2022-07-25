using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SkillManager : GenericManager<Skill>, ISkillService
    {
        public SkillManager(IGenericRepository<Skill> repository) : base(repository)
        {
        }
    }
}