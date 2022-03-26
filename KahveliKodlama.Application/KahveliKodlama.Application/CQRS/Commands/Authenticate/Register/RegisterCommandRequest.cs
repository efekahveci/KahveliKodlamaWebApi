using KahveliKodlama.Application.Attributes;
using KahveliKodlama.Domain.Entities;
using MediatR;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;

public class RegisterCommandRequest:IRequest<ResponseResult>
{
    [Username]
    public string Username { get; set; }
    [Email]
    public string Email { get; set; }
    [Password]
    public string Password { get; set; }
}
