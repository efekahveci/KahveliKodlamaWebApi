using KahveliKodlama.Domain.Entities;
using MediatR;

namespace KahveliKodlama.Application.CQRS.Queries.Authenticate;

public class GetUsersQueryRequest:IRequest<ResponseResult>
{
}
