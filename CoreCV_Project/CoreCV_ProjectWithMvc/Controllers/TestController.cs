using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
