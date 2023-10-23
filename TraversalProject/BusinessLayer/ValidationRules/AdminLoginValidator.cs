using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminLoginValidator : AbstractValidator<AdminLoginDTOs>
    {
        public AdminLoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Admin UserName Boş Olamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Admin Password Boş Olamaz");
        
        }
    }
}
