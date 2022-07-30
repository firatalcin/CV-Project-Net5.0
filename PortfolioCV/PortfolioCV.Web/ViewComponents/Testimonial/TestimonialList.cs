using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCV.Web.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialList(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _testimonialService.GetAll();
            return View(list);
        }
    }
}