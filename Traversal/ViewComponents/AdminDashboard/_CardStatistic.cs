using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _CardStatistic : ViewComponent
    {
        Context context = new Context();   
        public IViewComponentResult Invoke()
        {
            ViewBag.destinationCount = context.Destinations.Count();
            ViewBag.userCount = context.Users.Count();
            return View();
        }
    }
}
