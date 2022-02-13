using FluentValidation;
using KahveliKodlama.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register_Admin
{
    public class RegisterAdminCommandValidator:AbstractValidator<RegisterAdminCommandRequest>
    {
        public RegisterAdminCommandValidator()
        {
            RuleFor(p => p.Email)
               .NotEmpty().WithMessage(MessageHelper.validEmpty)
               .EmailAddress().WithMessage(MessageHelper.validEmail);

            RuleFor(p => p.Password).MinimumLength(5).MaximumLength(15).NotEmpty().WithMessage(MessageHelper.validEmpty);
            RuleFor(p => p.Key).NotEmpty().WithMessage(MessageHelper.validKey);

            RuleFor(p => p.Username).Matches(@"^[a-zA-Z-']*$").WithMessage(MessageHelper.validTurkishError)
                .MinimumLength(3)
                .MaximumLength(15)
                .NotEmpty().WithMessage(MessageHelper.validEmpty);
        }
    }
}
