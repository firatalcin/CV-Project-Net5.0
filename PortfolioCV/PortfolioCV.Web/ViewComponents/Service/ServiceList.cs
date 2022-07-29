using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        private readonly IServiceService _service;

        public ServiceList(IServiceService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.GetAll();
            return View(values);
        }
    }
}