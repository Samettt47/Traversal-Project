
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalProject.Areas.AdminsArea.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    public class ApiMovieController : Controller
    {
        [AllowAnonymous]
        [Area("AdminsArea")]
        public async Task<IActionResult> Index()
        {
			List<ApiMoviewViewModel> apiMovies = new List<ApiMoviewViewModel>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "f1b8e3ad3emsh9efc612bf58cc10p106ca9jsn13b4fe1361f8" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request)) // client'a istek at 
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync(); // İLGİLİ  GELEEN STATUS İÇERİĞİ(CONTENT) OKUYACAK 
				apiMovies = JsonConvert.DeserializeObject<List<ApiMoviewViewModel>>(body);// BURADA ISE DESERİALİZE  İLE VERİYİ JSON'DAN NORMAL(object) FORMATA CEVIRIYORUZ.
				return View(apiMovies);
			}
		
		}
    }
}
