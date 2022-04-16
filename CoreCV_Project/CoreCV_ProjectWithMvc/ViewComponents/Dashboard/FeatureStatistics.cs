using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
