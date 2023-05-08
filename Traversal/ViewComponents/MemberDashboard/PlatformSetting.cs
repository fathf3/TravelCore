using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
