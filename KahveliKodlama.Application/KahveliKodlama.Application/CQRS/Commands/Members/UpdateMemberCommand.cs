using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.CQRS.Commands.Members
{
    public class UpdateMemberCommand: IRequest<List<MemberDto>>
    {
        public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommand, List<MemberDto>>
        {
            private readonly IMemberService _memberService;
            private readonly IMapper _mapper;

            public UpdateMemberCommandHandler(IMemberService memberService, IMapper mapper)
            {
                _memberService = memberService;
                _mapper = mapper;
            }

            public async Task<List<MemberDto>> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
            {
               var result = _mapper.Map<Member>(request);


               var retval = await _memberService.GetById(result.Id);

               await  _memberService.Update(retval);

                return null;

            }
        }
    }
}
