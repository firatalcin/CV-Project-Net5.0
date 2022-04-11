using BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using CoreCV_Project.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreCV_ProjectWithMvc.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
     
        public IViewComponentResult Invoke()
        {
            
            return View();
        }

      
    }
}


