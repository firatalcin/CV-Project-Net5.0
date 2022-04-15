using BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class ServiceController : Controller
    {

        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Listele";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Hizmet Listeleme";
            var values = serviceManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            var service = serviceManager.TGetById(id);
            serviceManager.TRemove(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.d1 = "Ekleme";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Hizmet Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {

            ViewBag.d1 = "Düzenleme";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Hizmet Düzenleme";
            var service = serviceManager.TGetById(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }

    }
}
