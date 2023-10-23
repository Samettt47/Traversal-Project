using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar2 : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _MemberLayoutNavbar2(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = value.Name;
            ViewBag.SurName = value.SurName;
            ViewBag.UserName = value.UserName;
            ViewBag.Image = value.ImageUrl;

            return View();
        }
    }
}
