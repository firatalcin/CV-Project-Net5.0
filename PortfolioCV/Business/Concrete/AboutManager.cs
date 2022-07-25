using Business.Abstract;
using DataAccess.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : GenericManager<About>, IAboutService
    {
        public AboutManager(IGenericRepository<About> repository) : base(repository)
        {
        }
    }
}