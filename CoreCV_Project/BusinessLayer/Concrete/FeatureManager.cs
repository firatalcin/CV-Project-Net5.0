using CoreCV_Project.BusinessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TAdd(Feature entity)
        {
            _featureDal.Add(entity); 
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void TRemove(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }

        public List<Feature> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
