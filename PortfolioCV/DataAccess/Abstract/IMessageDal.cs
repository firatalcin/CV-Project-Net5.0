using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMessageDal : IGenericRepository<Message>
    {
    }
}