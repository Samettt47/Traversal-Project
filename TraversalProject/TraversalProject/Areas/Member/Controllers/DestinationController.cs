using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.Member.Controllers
{
    
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        public IActionResult GetCitiesBySearchByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in destinationManager.TGetList() select x; // BURADA İÇERİSİNDE İLGİLİ STRİNG'İ ARAMA YAPIYOR.
            if (!string.IsNullOrEmpty(searchString))  // GÖNDEDİĞİM DEĞER BOŞ DEĞİLİSE
            { 
                values = values.Where(y => y.City.ToLower().Contains(searchString.ToLower())); // EĞER İLGİLİ ARANAN KELİME VERİTABANINDA Kİ CİTY
                var newValues = JsonConvert.SerializeObject(values);
                return Json(newValues);                                                           // DEĞERİNİ İÇERİYORSA BUNU BİZE GETİRECEK               
            }
            return View(values.ToList());
        }
      
    }
}
