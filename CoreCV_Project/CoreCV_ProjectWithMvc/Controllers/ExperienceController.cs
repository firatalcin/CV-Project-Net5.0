using BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Listele";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Listeleme";
            var experience = experienceManager.TGetList();
            return View(experience);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.d1 = "Ekleme";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience e)
        {
            experienceManager.TAdd(e);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var experience = experienceManager.TGetById(id);
            experienceManager.TRemove(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.d1 = "Güncelleme";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Güncelleme";
            var experience = experienceManager.TGetById(id);
            return View(experience);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience e)
        {
            experienceManager.TUpdate(e);
            return RedirectToAction("Index");
        }
    }
}
