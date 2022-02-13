using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Login
{
    public class LoginCommandRequest:IRequest<ResponseResult>
    {
    
        public string Email { get; set; }

     
        public string Password { get; set; }
    }
}
