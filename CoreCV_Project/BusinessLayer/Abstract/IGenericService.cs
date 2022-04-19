using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCV_Project.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T entity);
        void TRemove(T entity);
        void TUpdate(T entity);
        List<T> TGetList();
        T TGetById(int id);
        List<T> TGetListbyFilter();
    }
}
