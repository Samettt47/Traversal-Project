using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.AnnouncementTitle).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.AnnouncementContent).NotEmpty().WithMessage("Duyuru içeriğini boş geçmeyiniz");

            RuleFor(x => x.AnnouncementTitle).MinimumLength(5).WithMessage("Başlık içeriğini lütfen en az 5 karakter giriniz");
            RuleFor(x => x.AnnouncementContent).MinimumLength(20).WithMessage("Duyuru içeriğini lütfen en az 20 karakter giriniz");

            RuleFor(x => x.AnnouncementTitle).MaximumLength(50).WithMessage("Başlık içeriğini lütfen en fazla 50 karakter giriniz");
            RuleFor(x => x.AnnouncementContent).MaximumLength(500).WithMessage("Duyuru  içeriğini lütfen en fazla 500 karakter giriniz");
        }
    }
}
