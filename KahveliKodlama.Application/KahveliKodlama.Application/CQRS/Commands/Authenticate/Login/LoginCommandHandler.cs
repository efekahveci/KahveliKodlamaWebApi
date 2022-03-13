using KahveliKodlama.Application.Contract;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, ResponseResult>
    {
        private readonly IAuthService _authService;

        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ResponseResult> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
        
            var valid = new LoginCommandValidator();

            var response = await valid.ValidateAsync(request);

     

            if (response.IsValid)   
                return await _authService.Login(request);

            return new ResponseResult(Domain.Enum.ResponseCode.No_Content, MessageHelper.validError, response.Errors.Select(x=>x.ErrorMessage));
        }
    }
}
