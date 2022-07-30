using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
