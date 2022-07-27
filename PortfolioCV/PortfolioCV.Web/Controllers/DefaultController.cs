using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
