using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T t);

        void Remove(T t);

        void Update(T t);
    }
}