using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {

        DestinationManager manager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = manager.TGetList();
            return View(values);
        }

        public IActionResult GetCitiesSearchByName(string search)
        {
            ViewData["CurrentFilter"] = search;
            var values = from x in manager.TGetList() select x;
            if (!string.IsNullOrEmpty(search))
            {
                values = values.Where(y => y.CityName.Contains(search));

            }
            return View(values.ToList());
        }

    }
}
