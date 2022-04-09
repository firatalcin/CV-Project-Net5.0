using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
