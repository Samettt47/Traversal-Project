using DTOLayer.DTOs.AppUserDTOs;
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
    public class AdminLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public AdminLoginController(SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager = null)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginDTOs adminLoginDTOs)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync
                    (adminLoginDTOs.UserName, adminLoginDTOs.Password, false, true);
                var user = await _userManager.FindByNameAsync(adminLoginDTOs.UserName);
                if (result.Succeeded  && user !=null)
                {
                    var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "AdminsArea" });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Bu sayfaya erişim izniniz yok.");
                        return View();
                    }
                }
                return RedirectToAction("Login", "AdminLogin");
            }
            return View();
        }

    }
}
