using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Area("AdminsArea")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationId)
        {

            var values = _destinationService.GetByID(DestinationId);

            if(values == null)
            {
               
            }
            else
            {
                var jsonValues = JsonConvert.SerializeObject(values);
                return Json(jsonValues);
            }
            return RedirectToAction("Index");
           
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.GetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
   
            var values = _destinationService.GetByID(destination.DestinationId);

            if (values  == null )
            {
                return BadRequest("Girdiğiniz ID değerine ait herhangi bir kayıt bulunamadı.");
            }
            else {

                destination.Price = values.Price;
                destination.Image = values.Image;
                destination.Description = values.Description;
                destination.Capasity = values.Capasity;
                destination.Status = values.Status;
                destination.CoverImage = values.CoverImage;
                destination.Details1 = values.Details1;
                destination.Details2 = values.Details2;
                destination.Image2 = values.Image2;

                _destinationService.TUpdate(destination);
                var jsonValues = JsonConvert.SerializeObject(destination);
                return Json(jsonValues);
            }
           
          
        }

        //public static List<CityClass> Cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        CityID = 1,
        //        CityName = "Üsküp",
        //        CityCountry = "Makedonya"

        //    },
        //    new CityClass
        //    {
        //        CityID =2 ,
        //        CityName = "Roma",
        //        CityCountry = "İtalya"
        //    },
        //    new CityClass
        //    {
        //        CityID = 3 ,
        //        CityName = "Londra",
        //        CityCountry = "İngiltere"
        //    }
        //};

      
    }
}
