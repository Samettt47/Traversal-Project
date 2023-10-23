using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Rehber Adını Giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Rehber Açıklamasını Giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Rehber Görselini Giriniz");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Daha Az Bir İsim Giriniz");
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("Lütfen 10 Karakterden Daha Fazla Bir İsim Giriniz");
        }
    }
}
