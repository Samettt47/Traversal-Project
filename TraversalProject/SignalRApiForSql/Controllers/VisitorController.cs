using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRApiForSql.DAL;
using SignalRApiForSql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiForSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;

        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        [HttpGet]
        public IActionResult CreateVisitor()
        {

            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (Ecity item in Enum.GetValues(typeof(Ecity))) // MANTIKEN 10*5 = 50 TANE VERİ LİSTELENECEK VERİ TABANINDA CUNKU DAHA ONCE RANGE AYARINI 1,5 ARASI YAPMISTIK !!!
                {
                    var newVisitor = new Visitor
                    {
                        City = item, // Burada visitordan gelen City değeri  Ecity' deki item ' ı
                                     // tutacak o yüzden direk eşitledik
                        CityvisitCount = random.Next(100, 200),
                        VisitDate = DateTime.Now.AddDays(x) // x 10 farklı değer alacak
                    };
                    _visitorService.SaveVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(1000); // Her bir ekleme işlemini saniyede 1 kez gerçekleştir.
                }
            });   // burada 10 günlük işlem olacagı ıcın  aralık böyle oldu NOTLARIMA BAK ORADA SEBEB YAZIYOR.
            return Ok("Ziyaretçiler başarılı bir şekilde eklendi");

        }
    }
}
