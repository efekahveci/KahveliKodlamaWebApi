using FluentValidation;
using KahveliKodlama.Core.Extensions;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole;

public class AddRoleCommandValidator : AbstractValidator<AddRoleCommandRequest>
{
    public AddRoleCommandValidator()
    {
        RuleFor(p => p.Rolename).Matches(@"^[a-zA-Z-']*$").WithMessage(MessageHelper.validTurkishError)
        .MinimumLength(3).WithMessage(MessageHelper.validMin)
        .MaximumLength(15).WithMessage(MessageHelper.validMax)
        .NotEmpty().WithMessage(MessageHelper.validEmpty);
    }
}
