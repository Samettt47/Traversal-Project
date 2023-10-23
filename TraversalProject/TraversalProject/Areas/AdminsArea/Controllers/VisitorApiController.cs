using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.Areas.AdminsArea.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [AllowAnonymous]
    [Area("AdminsArea")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); // Bana bir tane client olustursun
            var responseMessage = await client.GetAsync("http://localhost:9700/api/Visitor"); // GET METODU KULLAN NEREDE HANGI APIDE
                                                                                              // YAZMIS OLDUGUMUZ APININ URLINDE BU COK ONEMLIIII
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); // İLGİLİ  GELEEN STATUS İÇERİĞİ(CONTENT) OKUYACAK 
                var values = JsonConvert.DeserializeObject<List<VisitorViewModel>>(jsonData); // BURADA ISE DESERİALİZE  İLE VERİYİ JSON'DAN NORMAL FORMATA CEVIRIYORUZ.
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddVisitor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVisitor(VisitorViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model); // BURADA ISE SERİALİZE KULLANDIK CUNKU EKLEME OLDUGU ICIN OBJECT
                                                               // OLARAK GELEN VERIYI JSON YAPMAMIZ GEREKCEKTIR
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json"); // BURADA İÇERİĞİ VERİYOIRUZ YANI EKLEMEK ISTEDGIMIZ İÇERİĞİN
                                                                                                    // UTF8 FORAMTINDA VE JSON FORMATINDA OLDUGUNU BELIRTIYORUZ
            var responseMessage = await client.PostAsync("http://localhost:9700/api/Visitor" , content);      // BURADA DIKKAT ET ONEMLI OOLAN GET ASYNC DEGIL POSTASYNC OLARAK CALISIYOR !!!!!
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

       
        public async Task<IActionResult> DeleteVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:9700/api/Visitor/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:9700/api/Visitor/{id}"); // id'ye ait verileri getirmek ıcın kullandık
                                                                                                    // GET LİSTTEN FARKI SU BURADA ID VERDIGIIZ ICIN
                                                                                                    // TUMM VERILERI DEGIL O ID'YE AIT VERILERI responseMessage DA TUTUYOR
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); // Burada veriyi yani ilgili id'ye ait veriyi listeleyecek inputlara
                var values = JsonConvert.DeserializeObject<VisitorViewModel>(jsonData); // Verileri Inputları yazdırmak ıcın bu KOD KULLANILDI
                return View(values);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateVisitor(VisitorViewModel model)
        {
            var client = _httpClientFactory.CreateClient();     // BURASI AYNI EKLEME ISLEMINDE OLDUGU GIBI OLACAK 
            var jsonData = JsonConvert.SerializeObject(model);  // TEK FARKI SERİALZE EDERKEN PUTASYNC OLACAK KI BUNUN PUT ISLEMI OLDUGUNU BILSIN
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:9700/api/Visitor", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
