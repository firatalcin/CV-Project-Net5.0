using BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Listele";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Listele";
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.d1 = "Ekleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Ekleme";
            return View();
        }


        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }
    }
}
