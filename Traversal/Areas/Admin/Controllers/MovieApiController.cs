using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Traversal.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traversal.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class MovieApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> movies = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                 {
                     { "X-RapidAPI-Key", "a2c2e36cccmshf525ca733a1354cp1a4bdajsn5d634bcb1845" },
                     { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
                 },
                         };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                movies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(movies);
            }
        }
    }
}
