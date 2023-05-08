using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new  EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async  Task<IActionResult> MyReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var reservationList = reservationManager.GetListReservationWithDestination(values.Id);
            return View(reservationList);
        }
            
        public async Task<IActionResult> MyOldReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var reservationList = reservationManager.GetListReservationWithDestination(values.Id);
            return View(reservationList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.Destination = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 2;
            reservation.ReservationStatus = "Onay Bekliyor";
            reservationManager.TAdd(reservation);
            return View("MyReservations");
        }
    }
}
