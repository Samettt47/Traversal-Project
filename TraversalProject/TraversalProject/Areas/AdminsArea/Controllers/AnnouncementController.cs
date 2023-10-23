using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Areas.AdminsArea.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [AllowAnonymous] // Buraya sonra kaldır.
    [Area("AdminsArea")]
    public class AnnouncementController : Controller
    {
      
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;
        public AnnouncementController(IAnnouncementService announcementService , IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement() { 
                    AnnouncementContent = model.AnnouncementContent,
                    AnnouncementTitle = model.AnnouncementTitle,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.GetByID(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementId = model.AnnouncementId,
                    AnnouncementTitle = model.AnnouncementTitle,
                    AnnouncementContent = model.AnnouncementContent,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
