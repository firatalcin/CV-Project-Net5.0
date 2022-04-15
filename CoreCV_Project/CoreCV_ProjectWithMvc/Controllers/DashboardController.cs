using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.d1 = "Default";
            ViewBag.d2 = "Dashboard";
            ViewBag.d3 = "Default";
            return View();
        }
    }
}
