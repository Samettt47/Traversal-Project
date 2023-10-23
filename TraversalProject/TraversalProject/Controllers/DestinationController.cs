using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    [AllowAnonymous]
    [Route("Destination")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var DestinationList = destinationManager.TGetList();
            return View(DestinationList);
        }
        [HttpGet]
        [Route("DestinationDetailsForNonAuthenticate")]
        public IActionResult DestinationDetailsForNonAuthenticate(int id)
        {
            ViewBag.i = id;
            
            var values = destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        [Route("DestinationDetails/{id}")]
        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;    
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            TempData["userName"] = value.Name + " " + value.SurName;
            ViewBag.userID = value.Id;
            var values = destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        [HttpPost]
        [Route("DestinationDetails/{id}")]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
            
        }
    }
}
