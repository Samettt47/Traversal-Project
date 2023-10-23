using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Controllers
{
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
            // BİZE BİR TOKEN ÜRETMESİ GEREKİYOR BBU TOKEN BENZERSİZ BİR KEY OLUYOR MAİLE GELEN O KOD 
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange", new
            {

                userId = user.Id,  // Yukarıda verdiğimiz Actiona giderken bir kullanıcı ID ve o token ile gitmiş oalcak ki şifre sıfırlama işlemi gerçekleşebilek .
                token = passwordResetToken

            }, HttpContext.Request.Scheme); // Kişi gönderilen o linke tıklayınca ResetPassword adında actiona gidicek

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("admin", "treversalproject@gmail.com"); // GÖNDERNE BİLGİSİ
            mimeMessage.From.Add(mailboxAddressFrom); // KULLANICIYE HANGİ ADRESTEN GELDİĞİNİ BİLDİRMİŞ OLDUK
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgetPasswordViewModel.Mail); // Alıcak olan kısının adresını bıldırdık
            mimeMessage.To.Add(mailboxAddressTo); // BU SEFER KİME GİDECEKSE MESSAGE EKLENECEK

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink; // Maail içeriğine token LİNKİNİ GÖNDER

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Değişiklik Talebi";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);

            smtpClient.Authenticate("treversalproject@gmail.com", "xlzftltqcsfnwehc");

            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId, string token) // SAYFA AÇILDIĞINDA YUKARIDA Kİ METOTTAKİ USERID VE TOKEN VERDİĞİMİZ İÇİ BU TOKEN VE
                                                                        // USERID NIN DOĞRULAMASI YAPILMASI GEREKIYOR O YUZDEN PARAMETRE OLARKA BUNLARI VERDIK
        {
            TempData["userid"] = userId;
            TempData["token"] = token;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel) // SAYFA AÇILDIĞINDA YUKARIDA Kİ METOTTAKİ USERID VE TOKEN VERDİĞİMİZ İÇİ BU TOKEN VE
                                                                                                      // USERID NIN DOĞRULAMASI YAPILMASI GEREKIYOR O YUZDEN PARAMETRE OLARKA BUNLARI VERDIK
        {
            var userID = TempData["userid"];
            var token = TempData["token"];
            if (userID == null || token == null)
            {

                // Hata Mesajı
            }

            var user = await _userManager.FindByIdAsync(userID.ToString());

            if(user== null)
            {
                return View();
            }

            var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password); // Özel bir metot ŞİFRE YENİLEME METODU.
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();


        }
    }
}