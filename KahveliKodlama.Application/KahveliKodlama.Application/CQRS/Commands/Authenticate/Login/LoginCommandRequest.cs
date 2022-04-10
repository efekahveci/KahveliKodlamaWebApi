using KahveliKodlama.Application.Attributes;
using KahveliKodlama.Domain.Entities;
using MediatR;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Login;

public class LoginCommandRequest : IRequest<ResponseResult>
{
    [Email]
    public string Email { get; set; }
    [Password]
    public string Password { get; set; }
}
