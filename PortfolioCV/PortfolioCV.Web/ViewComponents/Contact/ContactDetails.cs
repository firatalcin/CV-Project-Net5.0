using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactDetails(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _contactService.GetAll();
            return View(list);
        }
    }
}