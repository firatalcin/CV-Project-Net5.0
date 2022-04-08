using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Concrete.Repository;
using CoreCV_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCV_Project.DataAccessLayer.Concrete.EntityFramework
{
    public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal
    {
    }
}
