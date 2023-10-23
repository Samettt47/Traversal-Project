using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Area("AdminsArea")]
    [Route("AdminsArea/ContactUs")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly Context _context;
        public ContactUsController(IContactUsService contactUsService, Context context)
        {
            _contactUsService = contactUsService;
            _context = context;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _contactUsService.TGetListContactUsByTrue();
            return View(values);
        }

        [Route("AddtoRecycleBin/{id}")]
        public IActionResult AddtoRecycleBin(int id)
        {
            _contactUsService.TContactUsStatusChangeToFalse(id);
            return RedirectToAction("Index", "ContactUs");

        }
        [Route("RecycleBinList")]
        public IActionResult RecycleBinList()
        {
            var values = _contactUsService.TGetListContactUsByFalse();
            return View(values);
        }
        [Route("DeleteMessage/{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _contactUsService.GetByID(id);
            _contactUsService.TDelete(value);
            return RedirectToAction("RecycleBinList", "ContactUs");

        }
    }
}
