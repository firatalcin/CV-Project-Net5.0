using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
