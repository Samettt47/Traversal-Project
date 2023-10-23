using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Area("AdminsArea")]
    [Route("AdminsArea/User")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;
        public UserController(IAppUserService appUserService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetByID(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("EditUser/{id}")]
        public async Task<IActionResult> EditUser(int id)
        {
            var value = await _userManager.FindByIdAsync(id.ToString());
            TempData["user"] = value.UserName;
            ChangeUserDataViewModel model = new ChangeUserDataViewModel();
            model.name = value.Name;
            model.surname = value.SurName;
            model.userName = value.UserName;
            return View(model);
        }

        [HttpPost]
        [Route("EditUser/{id}")]
        public async Task<IActionResult> EditUser(ChangeUserDataViewModel changeUserDataViewModel)
        {
            var user = await _userManager.FindByNameAsync(TempData["user"].ToString()) ;
            //appUser.PhoneNumber = value.PhoneNumber;
            user.Name = changeUserDataViewModel.name;
            user.SurName = changeUserDataViewModel.surname;
            user.UserName = changeUserDataViewModel.userName;
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
           
        }


        [Route("ReservationUser/{id}")]
        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
