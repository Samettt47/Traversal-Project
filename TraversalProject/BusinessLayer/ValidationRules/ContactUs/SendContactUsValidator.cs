using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez")
                .EmailAddress().WithMessage("Lütfen Geçerli bir mail adresi giriniz!");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı Boş Geçilemez");

            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez");

            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi yapmalısınız");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter veri girişi yapmalısınız");

            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi yapmalısınız");
            RuleFor(x => x.Subject).MaximumLength(35).WithMessage("Konu alanına en fazla 35 karakter veri girişi yapmalısınız");
        }

    }
}
