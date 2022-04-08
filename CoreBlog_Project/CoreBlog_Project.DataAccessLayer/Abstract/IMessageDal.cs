
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBlog_Project.EntityLayer.Concrete;

namespace CoreBlog_Project.DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
    }
}
