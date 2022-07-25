using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SocialMediaManager : GenericManager<SocialMedia>, ISocialMediaService
    {
        public SocialMediaManager(IGenericRepository<SocialMedia> repository) : base(repository)
        {
        }
    }
}