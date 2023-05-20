using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Traversal.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace Traversal.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BookingOtelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=EUR&dest_id=-1456928&locale=en-gb&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
                Headers =
                  {
                      { "X-RapidAPI-Key", "a2c2e36cccmshf525ca733a1354cp1a4bdajsn5d634bcb1845" },
                      { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                  },
                          };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingSearchViewModel>(body);
                return View(values.results);
            }
           
        }

        [HttpGet]
        public async Task<IActionResult> GetCityDestID()
        { 
            return View();
        }


            [HttpPost]
        public async Task<IActionResult> GetCityDestID(string city)
        {
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=en-gb"),
                Headers =
                {
                    { "X-RapidAPI-Key", "a2c2e36cccmshf525ca733a1354cp1a4bdajsn5d634bcb1845" },
                    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }

    }
}
