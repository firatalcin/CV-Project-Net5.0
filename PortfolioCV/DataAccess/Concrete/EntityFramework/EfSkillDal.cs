using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSkillDal : GenericRepository<Skill>, ISkillDal
    {
        public EfSkillDal(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}