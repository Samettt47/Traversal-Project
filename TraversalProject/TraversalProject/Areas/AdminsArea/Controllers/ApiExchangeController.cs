using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using TraversalProject.Areas.AdminsArea.Models;
using Newtonsoft.Json;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    public class ApiExchangeController : Controller
    {
        [Area("AdminsArea")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            List<BookingExcangeViewModel2> bookingModal = new List<BookingExcangeViewModel2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=AED&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "f1b8e3ad3emsh9efc612bf58cc10p106ca9jsn13b4fe1361f8" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values  = JsonConvert.DeserializeObject<BookingExcangeViewModel2>(body);
                return View(values.exchange_rates);
            }
            
        }
    }
}
