using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}