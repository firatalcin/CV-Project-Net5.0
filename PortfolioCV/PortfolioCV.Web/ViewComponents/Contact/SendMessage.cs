using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        private readonly IMessageService _messageService;

        public SendMessage(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message m)
        //{
        //    m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    m.Status = true;
        //    _messageService.Add(m);
        //    return View();
        //}
    }
}