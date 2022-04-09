using BusinessLayer.Concrete;
using CoreCV_Project.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV_ProjectWithMvc.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
