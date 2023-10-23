using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Area("AdminsArea")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mail)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("admin" , "treversalproject@gmail.com"); // GÖNDERNE BİLGİSİ
            mimeMessage.From.Add(mailboxAddressFrom); // KULLANICIYE HANGİ ADRESTEN GELDİĞİNİ BİLDİRMİŞ OLDUK
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mail.ReceiverMail); // Alıcak olan kısının adresını bıldırdık
            mimeMessage.To.Add(mailboxAddressTo); // BU SEFER KİME GİDECEKSE MESSAGE EKLENECEK

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mail.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mail.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);

            smtpClient.Authenticate("treversalproject@gmail.com", "xlzftltqcsfnwehc");

            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return RedirectToAction("Index");
        }
    }
}
//treversalproject@gmail.com
