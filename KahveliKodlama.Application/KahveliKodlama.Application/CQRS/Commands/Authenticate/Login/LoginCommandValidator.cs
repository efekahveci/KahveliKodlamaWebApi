using FluentValidation;
using KahveliKodlama.Core.Extensions;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommandRequest>
    {
        public LoginCommandValidator()
        {

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage(MessageHelper.validEmpty)
                .EmailAddress().WithMessage(MessageHelper.validEmail);
            RuleFor(p => p.Password).NotEmpty().WithMessage(MessageHelper.validEmpty);
        }
    }
}
