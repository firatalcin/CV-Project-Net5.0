using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.Controllers
{
    public class AdminController : Controller
    {
       public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
