using KahveliKodlama.Domain.Entities;
using MediatR;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole
{
    public class AddRoleCommandRequest:IRequest<ResponseResult>
    {
        public string Rolename { get; set; }
    }
}
