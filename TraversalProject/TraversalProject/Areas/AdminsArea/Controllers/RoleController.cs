using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Areas.AdminsArea.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Area("AdminsArea")]
    [Route("AdminsArea/Role")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        [Route("CreateRole")]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            AppRole role = new AppRole()
            {
                Name = createRoleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }


        }
        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateRole/{id}")]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleID = values.Id,
                RoleName = values.Name

            };
            return View(updateRoleViewModel);
        }
        [HttpPost]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleID);
            values.Name = updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(values);
            return RedirectToAction("Index");
        }

        [Route("UserList")]
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["Userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user); // user'a ait kullnıcının rolunu getir
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in roles)  // LİSTELENEN MODELLERE BURADA YENİ BİR MODEL EKLİYOR. ROLLERİN İÇERİSİNDEN OKU
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name); // kullanıcı rolleri içerisinde kullanıcının name değeri var mı ( item den gelen ) / true yada false olacak
                roleAssignViewModels.Add(model);
            }
            // ben bu VİEV MODEL'IMI  LİSTELERİM SONRASINDA ROLES' ICERISINDE GEZERIM GEZMİŞ OLDUĞUM ROLES İÇERİSİNDE
            // VİEWMODEL'I LİSTELYECEĞİM İÇİN EŞİTLEME ( ATAMA ) YAPARIM SONRA LİSTELERİM Kİ İÇERİSİNE VERİ GELSİN
            return View(roleAssignViewModels);
        }
        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)  // burada TEK BİR ROLE İLE ÇALIŞMAYACAGIZ YANİ AYNI ANDA BİRDEN
                                                       // FAZLA ROL GÜNCELLEMEK İSTEDİĞİMİZ İÇİN YUKARIDA BUNU ACIKLADIM
                                                       // BUNU RoleAssignViewModel'ı List<> olarak göndermemiz gerekecek.
        {
            var userid = (int) TempData["Userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in model)
            {
                if (item.RoleExist) // EĞER Kİ CHECKBOX SEÇİLİ DEĞERLERİ SEÇİLMİŞSE (TRUE) YANİ O ROLE O USER'A İŞARETLEMİŞSEK
                                    // O ROLU O KULLANICIYA EKLE
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else                // eğer ki SEÇİLİYİ KALDIRMIŞSAK VEYA HALA SEÇİLMEMİŞSE o rolu FALSE YAP (VEYA KALDIR ) 
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
              

            }
            return RedirectToAction("UserList");
        }
    }

}
