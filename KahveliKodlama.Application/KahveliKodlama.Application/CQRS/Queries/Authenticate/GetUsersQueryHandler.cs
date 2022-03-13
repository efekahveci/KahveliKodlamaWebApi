using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Queries.Authenticate
{
    public class GetUsersHandler : IRequestHandler<GetUsersQueryRequest, ResponseResult>
    {
        private readonly IAuthService _authService;

        public GetUsersHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ResponseResult> Handle(GetUsersQueryRequest request, CancellationToken cancellationToken)
        {
            return  await _authService.GetUsersAsync();
        }
    }
}
