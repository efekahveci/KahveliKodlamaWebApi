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

namespace KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole
{
    public class AddRoleCommandHandler : IRequestHandler<AddRoleCommandRequest, ResponseResult>
    {
        private readonly IAuthService _authService;

        public AddRoleCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        
        public async Task<ResponseResult> Handle(AddRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var valid = new AddRoleCommandValidator();

            var response = await valid.ValidateAsync(request);



            if (response.IsValid)
                return await _authService.AddRole(request);

            return new ResponseResult(Domain.Enum.ResponseCode.No_Content, MessageHelper.validError, response.Errors.Select(x => x.ErrorMessage));
        }
    }
    
}
