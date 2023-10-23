using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalProject.Areas.AdminsArea.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
	[AllowAnonymous]
	[Area("AdminsArea")]
	public class BookingHotelSearchController : Controller
    {
		
		
        public async  Task<IActionResult> Index()
        {
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?checkin_date=2023-10-27&dest_type=city&units=metric&checkout_date=2023-10-28&adults_number=2&order_by=popularity&dest_id=-1456928&filter_by_currency=EUR&locale=en-gb&room_number=1&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&include_adjacency=true"),
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
				
				var bodyReplace = body.Replace(".", "");

				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);

				for (int i = 0; i < values.result.Length; i++)
				{
					if (values.result[i].review_score == null)
					{
						values.result[i].review_score = 77;		
					}
				}

				return View(values.result);
			}			
        }


		[HttpGet]
		public IActionResult GetCityID()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> GetCityID(string p) // p parametresi burada şehir olacak
		{

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
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
				return View();
			}
		}


	}
}
