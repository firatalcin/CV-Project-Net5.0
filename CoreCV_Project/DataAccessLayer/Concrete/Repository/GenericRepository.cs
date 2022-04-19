using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreCV_Project.DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }           
        }

        public void Delete(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetbyFilter(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetList()
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
