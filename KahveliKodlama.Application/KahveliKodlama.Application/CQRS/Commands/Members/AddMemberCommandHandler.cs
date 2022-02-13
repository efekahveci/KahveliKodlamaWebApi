//using AutoMapper;
//using KahveliKodlama.Application.Contract;
//using KahveliKodlama.Application.Dto;
//using KahveliKodlama.Application.Validation;
//using KahveliKodlama.Domain.Entities;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace KahveliKodlama.Application.CQRS.Commands.Members
//{
   
//        public class AddMemberCommandHandler : IRequestHandler<AddMemberCommandRequest, ResponseResult>
//        {
//            private readonly IAuthService _authService;
//            private readonly IMapper _mapper;

//            public AddMemberCommandHandler(IAuthService authService, IMapper mapper)
//            {
//                _authService = authService;
//                _mapper = mapper;
//            }



//            public async Task<ResponseResult> Handle(AddMemberCommandRequest request, CancellationToken cancellationToken)
//            {

//               // var result   = _mapper.Map<RegisterDto>(request);

//                var valid = new AddMemberCommandValidator();

//              var response=  await valid.ValidateAsync(request);

//                if (response.IsValid)
//                {
                  

//                    await _authService.Register(request);

//                    return null;

//                }
//                else
//                {
                   

//                    return null;
//                }
                   
//            }
//        }
    
//}
