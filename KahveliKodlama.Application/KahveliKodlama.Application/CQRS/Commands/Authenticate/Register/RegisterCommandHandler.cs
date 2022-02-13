using KahveliKodlama.Application.Contract;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommandRequest, ResponseResult>
    {
        private readonly IAuthService _authService;

        public RegisterCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ResponseResult> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            var valid = new RegisterCommandValidator();

            var response = await valid.ValidateAsync(request);



            if (response.IsValid)
                return await _authService.Register(request);

            return new ResponseResult(Domain.Enum.ResponseCode.No_Content, MessageHelper.validError, response.Errors.Select(x => x.ErrorMessage));
        }
    }
}
