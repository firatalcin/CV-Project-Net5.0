using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T> where T : BaseEntity
    {
        void Add(T t);

        void Update(T t);

        void Delete(T t);

        List<T> GetAll();

        T GetById(int id);
    }
}