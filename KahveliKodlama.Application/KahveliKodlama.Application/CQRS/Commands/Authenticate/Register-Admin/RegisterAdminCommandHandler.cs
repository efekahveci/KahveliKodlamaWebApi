using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.Register_Admin
{
    public class RegisterAdminCommandHandler : IRequestHandler<RegisterAdminCommandRequest, ResponseResult>
    {
        private readonly IAuthService _authService;

        public RegisterAdminCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<ResponseResult> Handle(RegisterAdminCommandRequest request, CancellationToken cancellationToken)
        {
            var valid = new RegisterAdminCommandValidator();
            var response = await valid.ValidateAsync(request);



            if (response.IsValid)
                return await _authService.RegisterAdmin(request);

            return new ResponseResult(Domain.Enum.ResponseCode.No_Content, MessageHelper.validError, response.Errors.Select(x => x.ErrorMessage));
        }
    }
}
