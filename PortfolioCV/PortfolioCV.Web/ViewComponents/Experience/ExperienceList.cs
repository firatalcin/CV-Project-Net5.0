using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public ExperienceList(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _experienceService.GetAll();
            return View(list);
        }
    }
}