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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio entity)
        {
            _portfolioDal.Add(entity);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TRemove(Portfolio entity)
        {
            _portfolioDal.Delete(entity);
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }
    }
}
