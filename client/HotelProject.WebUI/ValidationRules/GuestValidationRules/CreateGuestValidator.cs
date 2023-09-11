using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("City Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen En Az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Lütfen En Az 2 karakter veri girişi yapınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen En Az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen En Fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen En Fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen En Fazla 20 karakter veri girişi yapınız");
       

        }
    }
}
