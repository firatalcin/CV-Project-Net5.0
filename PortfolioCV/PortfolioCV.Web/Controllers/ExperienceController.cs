using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var list = _experienceService.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            _experienceService.Delete(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience e)
        {
            _experienceService.Add(e);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            return View(experience);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience e)
        {
            _experienceService.Update(e);
            return RedirectToAction("Index");
        }
    }
}