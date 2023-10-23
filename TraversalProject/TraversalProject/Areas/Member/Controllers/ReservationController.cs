using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _usermanager;

        public ReservationController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            var valueslist = reservationManager.GetListWithReservationByAccepted(values.Id);

            if (valueslist == null || valueslist.Count == 0)
            {
                ViewBag.msg = "Onaylanan Rezervasyonunuz Bulunamadı";
            }

            return View(valueslist);
        }
        public async Task<IActionResult> MyOldReservation()
        {

            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            var valueslist = reservationManager.GetListWithReservationByPrevious(values.Id);

            if(valueslist == null || valueslist.Count == 0 )
            {
                ViewBag.msg = "Geçmiş Rezervasyonunuz Bulunamadı";
            }

            return View(valueslist);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            var valueslist = reservationManager.GetListWithReservationByWaitApproval(values.Id);

            if (valueslist == null || valueslist.Count == 0)
            {
                ViewBag.msg = "Onay Bekleyen Rezervasyonunuz Bulunamadı";
            }

            return View(valueslist);
        }

        [HttpGet]   
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList() // BU KOD DESTİNATİON TABLOSUNDAKİ
                                                                                   // CİTY'E SUTUNUNA AİT TUM VERİLERİ LİSTELER
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString(), // reservation da destinatıonı string verdik diye tostring yaptık.

                                           }).ToList();
            ViewBag.v = values;
            
                            
            return View();
        }   

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {

            var currenID = await _usermanager.GetUserAsync(User);

            reservation.AppUserId = currenID.Id;
            reservation.Status = "Onay Bekliyor";
            reservationManager.TAdd(reservation);
            return RedirectToAction("MyApprovalReservation");

        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}
