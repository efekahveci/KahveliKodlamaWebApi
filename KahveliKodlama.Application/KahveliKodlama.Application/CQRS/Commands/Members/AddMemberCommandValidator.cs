using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Members
{
    public  class AddMemberCommandValidator : AbstractValidator<AddMemberCommandRequest>
    {
        public AddMemberCommandValidator()
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
