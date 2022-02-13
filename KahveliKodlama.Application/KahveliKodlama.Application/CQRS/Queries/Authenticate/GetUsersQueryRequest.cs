using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Queries.Authenticate
{
    public class GetUsersQueryRequest:IRequest<ResponseResult>
    {
    }
}
