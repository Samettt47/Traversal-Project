using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models.ViewComponents.UILayout
{
    public class _UILayoutNavbar : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public _UILayoutNavbar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.NameAndSurmane = values.Name + " " + values.SurName;
                ViewBag.UserName = values.UserName;
                ViewBag.Img = values.ImageUrl;
                return View();
            }
            return View();
        }
    }
}
