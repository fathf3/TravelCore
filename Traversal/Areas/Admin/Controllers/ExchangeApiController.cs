using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Collections.Generic;
using Traversal.Areas.Admin.Models;
using Newtonsoft.Json;

namespace Traversal.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class ExchangeApiController : Controller
    {
        public async  Task<IActionResult> Index()
        {
         
            List<BookingExchangeViewModel2> bookingExchanges = new List<BookingExchangeViewModel2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
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
                var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(values.exchange_rates);
            }
           
        }
    }
}
