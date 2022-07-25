using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ProjectContext _projectContext;

        public GenericRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void Add(T t)
        {
            _projectContext.Add(t);
            _projectContext.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _projectContext.Set<T>().FirstOrDefault(filter);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                ? _projectContext.Set<T>().ToList()
                : _projectContext.Set<T>().Where(filter).ToList();
        }

        public void Remove(T t)
        {
            _projectContext.Remove(t);
            _projectContext.SaveChanges();
        }

        public void Update(T t)
        {
            _projectContext.Update(t);
            _projectContext.SaveChanges();
        }
    }
}