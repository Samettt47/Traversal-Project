using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    [Area("AdminsArea")]
    [Route("AdminsArea/SubAbout")]
  
    public class SubAboutController : Controller
    {
        private readonly ISubAboutService _subAboutService;

        public SubAboutController(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _subAboutService.TGetList();
            return View(values);
        }

        [Route("EditSubAbout/{id}")]
        [HttpGet]
        public IActionResult EditSubAbout(int id)
        {
            var values = _subAboutService.GetByID(id);
            return View(values);
        }

        [Route("EditSubAbout/{id}")]
        [HttpPost]
        public IActionResult EditSubAbout(SubAbout subAbout)
        {
            _subAboutService.TUpdate(subAbout);
            return RedirectToAction("Index");
        }
    }
}
