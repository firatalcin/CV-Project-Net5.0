using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public IActionResult Index()
        {
            var list = _skillService.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill s)
        {
            _skillService.Add(s);
            return RedirectToAction("Index");
        }
    }
}