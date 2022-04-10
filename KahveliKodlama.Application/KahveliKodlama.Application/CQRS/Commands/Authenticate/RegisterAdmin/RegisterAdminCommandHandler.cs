using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.RegisterAdmin;

public class RegisterAdminCommandHandler : IRequestHandler<RegisterAdminCommandRequest, ResponseResult>
{
    private readonly IAuthService _authService;

    public RegisterAdminCommandHandler(IAuthService authService)
    {
        _authService = authService;
    }
    public async Task<ResponseResult> Handle(RegisterAdminCommandRequest request, CancellationToken cancellationToken)
    {

        return await _authService.RegisterAdmin(request);

    }
}
