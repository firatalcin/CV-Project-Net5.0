using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;

        public DefaultController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessagePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessagePartial(Message m)
        {
            m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.Status = true;
            _messageService.Add(m);
            return PartialView();
        }
    }
}