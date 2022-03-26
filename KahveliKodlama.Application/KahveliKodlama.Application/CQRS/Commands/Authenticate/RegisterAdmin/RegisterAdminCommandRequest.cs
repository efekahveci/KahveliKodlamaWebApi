using KahveliKodlama.Application.Attributes;
using KahveliKodlama.Domain.Entities;
using MediatR;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.RegisterAdmin;

public class RegisterAdminCommandRequest:IRequest<ResponseResult>
{
    [Username]
    public string Username { get; set; }
    public string Key { get; set; }
    [Email]
    public string Email { get; set; }
    [Password]
    public string Password { get; set; }
}
