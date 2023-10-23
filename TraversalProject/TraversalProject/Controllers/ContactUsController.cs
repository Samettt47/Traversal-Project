using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDTO sendMessageDTO)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Name = sendMessageDTO.Name,
                    Subject = sendMessageDTO.Subject,
                    Mail = sendMessageDTO.Mail,
                    MessageBody = sendMessageDTO.MessageBody,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    MessageStatus = true
                });
                return RedirectToAction("Index", "Default");

            }
           
            return View(sendMessageDTO);
        }
    }
}
