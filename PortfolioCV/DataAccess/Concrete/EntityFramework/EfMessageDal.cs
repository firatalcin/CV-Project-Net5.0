using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public EfMessageDal(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}