using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PartialHeader()
        {
            return View();
        }

        public IActionResult PartialNavbar()
        {
            return View();
        }

        public IActionResult PartialNavbarForMobile()
        {
            return View();
        }
        public IActionResult PartialFooter()
        {
            return View();
        }public IActionResult PartialScripts()
        {
            return View();
        }


    }
}
