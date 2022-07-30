using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _portfolioService.GetAll();
            return View(list);
        }
    }
}