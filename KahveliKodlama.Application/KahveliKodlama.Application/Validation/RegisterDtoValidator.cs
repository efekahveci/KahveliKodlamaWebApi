using FluentValidation;
using KahveliKodlama.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Validation
{
    public class RegisterDtoValidator:AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            
                RuleFor(p => p.Username)
                    .NotNull()
                    .WithMessage("Lütfen Kullanıcı Adı'nı boş geçmeyiniz.")
                    .MaximumLength(20)
                    .MinimumLength(3)
                    .WithMessage("'Kullanıcı Adı' değeri 3 ile 20 karakter arasında olmalıdır.");
                RuleFor(p => p.Email)
                    .NotEmpty().WithMessage("Lütfen E-Mail adresi boş geçmeyiniz.")
                    .EmailAddress().WithMessage("Geçerli bir E-Posta adresi giriniz.");

        }
    }
}
