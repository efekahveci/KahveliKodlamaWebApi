using FluentValidation;
using KahveliKodlama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Validation
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(p => p.HeadingName)
                   .NotNull()
                   .WithMessage("Lütfen Başlık Adı'nı boş geçmeyiniz.")
                   .MaximumLength(20)
                   .MinimumLength(3)
                   .WithMessage("Başlık Adı' değeri 5 ile 20 karakter arasında olmalıdır.");
            RuleFor(p => p.HeadingContent)
                  .MaximumLength(500)
                  .MinimumLength(2)
                  .WithMessage("Başlık açıklaması 2 ile 500 karakter arasında olmalıdır.");
              
        }
    }
}
