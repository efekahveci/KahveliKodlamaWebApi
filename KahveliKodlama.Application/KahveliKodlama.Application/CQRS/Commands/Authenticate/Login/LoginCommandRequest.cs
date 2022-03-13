using KahveliKodlama.Domain.Entities;
using MediatR;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Login
{
    public class LoginCommandRequest:IRequest<ResponseResult>
    {
    
        public string Email { get; set; }

     
        public string Password { get; set; }
    }
}
