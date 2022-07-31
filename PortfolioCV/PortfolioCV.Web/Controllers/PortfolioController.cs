using Business.Abstract;
using Business.FluentValidation;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            var list = _portfolioService.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                _portfolioService.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            PortfolioValidator validations = new();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                _portfolioService.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            _portfolioService.Delete(portfolio);
            return RedirectToAction("Index");
        }
    }
}