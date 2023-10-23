using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Areas.Member.Models;

namespace TraversalProject.Areas.Member.Controllers
{
    [Authorize(Policy = "MemberPolicy")]
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); // Bu metot isme göre ilgili authentice
                                                                                 // olmus kullanıyıccıy bulur.

            UserEditViewModel userEditViewModel = new UserEditViewModel(); // bu oluşuturlan viewmodel proplarından nesne oluştur
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.SurName;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;

            // yukarıda ki metotlar ise OLUŞTRULAN NESNENIN PROPERTYLERINE VALUESTEKİ (YANİ VERİTABANINDAKİ) VERİLERİ İNPUTUN
            // İÇİNE YAZDIRIR

            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if(userEditViewModel.Image != null)
            {
                var resource = Directory.GetCurrentDirectory(); // RESMIN KAYNAGINI OLUSTURMA.
                var extension = Path.GetExtension(userEditViewModel.Image.FileName); // UZANTI EKLEME KODU  
                var imagename = Guid.NewGuid() + extension; // Resim ismi veriyoruz fakat guid ile random bi isim oluşturup bu
                                                            // resim isimlerinin çakışmaması ıcın guid yazıyoruz
                var savelocation = resource + "/wwwroot/UserImage/" + imagename;  // Resmin kaydedilecegi yer
                var stream = new FileStream(savelocation, FileMode.Create); // Akış yolu oluşturduk ki image'ı kaydetsın
                await userEditViewModel.Image.CopyToAsync(stream); // Buda Akışın gekdiği yere kopyala( EDİTVİEWMODALA KAYDET ) 
                user.ImageUrl = imagename; // Veritabanına kaydetme işlemi eşleştirme daha doğrusu
            }

            user.Name = userEditViewModel.name;
            user.SurName = userEditViewModel.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.password);

            var result = await _userManager.UpdateAsync(user); // İlgili tüm dataları güncelle
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn" , "Login");
            }
            return View();
            


        }

    }
}
