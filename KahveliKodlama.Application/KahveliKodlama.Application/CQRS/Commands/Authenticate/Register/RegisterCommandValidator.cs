using FluentValidation;
using KahveliKodlama.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register
{
    public class RegisterCommandValidator:AbstractValidator<RegisterCommandRequest>
    {
          public RegisterCommandValidator()
        {

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage(MessageHelper.validEmpty)
                .EmailAddress().WithMessage(MessageHelper.validEmail);

            RuleFor(p => p.Password).MinimumLength(3)
                .NotEmpty().WithMessage(MessageHelper.validEmpty);

            RuleFor(p => p.Username).Matches(@"^[a-zA-Z-']*$").WithMessage(MessageHelper.validTurkishError)
                .MinimumLength(3).WithMessage(MessageHelper.validMin)
                .MaximumLength(15).WithMessage(MessageHelper.validMax)
                .NotEmpty().WithMessage(MessageHelper.validEmpty);
        }

    }
}
