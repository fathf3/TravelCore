using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class Feature : ViewComponent
    {
        FeaturedManager manager = new FeaturedManager(new EfFeaturedDal());
        public IViewComponentResult Invoke() 
        {
            var values = manager.TGetList();
            return View(values); 
        }
    }
}
