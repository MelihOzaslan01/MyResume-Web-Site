using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myResume.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = FeatureManager.TGetList();
            return View(values);
        }
    }
}
