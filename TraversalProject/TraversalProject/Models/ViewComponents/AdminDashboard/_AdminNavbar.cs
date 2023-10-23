using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models.ViewComponents.AdminDashboard
{
    public class _AdminNavbar : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
      
        public _AdminNavbar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
          
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var rol = await _userManager.GetRolesAsync(user);
            var model = new NavbarViewModel
            {
                AdminName = user.Name,
                AdminSurname = user.SurName,
                ImageUrl = user.ImageUrl 
                

            };
            if (rol.Contains("Admin"))
            {
                model.Rol = "Admin";
            }
       
            return View(model);
        }
    }
}
