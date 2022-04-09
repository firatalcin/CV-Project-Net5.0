using BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}
