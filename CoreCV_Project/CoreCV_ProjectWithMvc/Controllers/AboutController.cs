using CoreCV_Project.BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult EditAbout()
        {
            ViewBag.d1 = "Düzenle";
            ViewBag.d2 = "Hakkımda";
            ViewBag.d3 = "Hakkımda Sayfası";
            var values = aboutManager.TGetById(1);
            return View(values);
        }


        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
