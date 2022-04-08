using CoreBlog_Project.DataAccessLayer.Abstract;
using CoreBlog_Project.DataAccessLayer.Concrete.Repository;
using CoreBlog_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog_Project.DataAccessLayer.Concrete.EntityFramework
{
    public class EfAboutDal : GenericRepository<About> , IAboutDal
    {
    }
}
