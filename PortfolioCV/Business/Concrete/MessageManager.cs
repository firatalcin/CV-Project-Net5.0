using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MessageManager : GenericManager<Message>, IMessageService
    {
        public MessageManager(IGenericRepository<Message> repository) : base(repository)
        {
        }
    }
}