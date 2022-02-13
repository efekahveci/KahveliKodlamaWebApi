using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register_Admin
{
    public class RegisterAdminCommandRequest:IRequest<ResponseResult>
    {
        public string Username { get; set; }
        public string Key { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
