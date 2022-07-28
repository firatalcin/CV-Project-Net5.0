using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public FeatureList(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetAll();
            return View(values);
        }
    }
}