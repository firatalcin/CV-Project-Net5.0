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
    public class GenericManager<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repository;

        public GenericManager(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T t)
        {
            _repository.Add(t);
        }

        public void Delete(T t)
        {
            _repository.Remove(t);
        }

        public List<T> GetAll()
        {
            return _repository.GetList();
        }

        public T GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public void Update(T t)
        {
            _repository.Update(t);
        }
    }
}