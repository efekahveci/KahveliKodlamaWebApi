using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole
{
    public class AddRoleCommandRequest:IRequest<ResponseResult>
    {
        public string Rolename { get; set; }
    }
}
