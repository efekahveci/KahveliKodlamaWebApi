using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, ResponseResult>
{
    private readonly IAuthService _authService;

    public LoginCommandHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<ResponseResult> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
    {

        return await _authService.Login(request);
    }
}
