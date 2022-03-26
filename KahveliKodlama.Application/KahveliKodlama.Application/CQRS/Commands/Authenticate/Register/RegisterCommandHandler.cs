using KahveliKodlama.Application.Contract;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommandRequest, ResponseResult>
{
    private readonly IAuthService _authService;

    public RegisterCommandHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<ResponseResult> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
    {
       
     return await _authService.Register(request);

    }
}
