using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Şifre Alanı Boş Geçilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Boş Geçilemez")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
