using AutoMapper;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KahveliKodlama.Application.Contract;

namespace KahveliKodlama.Application.CQRS.Queries.Members.GetByIdMember
{
    public class GetByIdMemberDtoQuery : IRequest<MemberDto>
    {
        public int Id { get; set; }

        public class ByMemberDtoQueryHandler : IRequestHandler<GetByIdMemberDtoQuery, MemberDto>
        {
            private readonly IMemberService _memberService;
            private readonly IMapper _mapper;

            public ByMemberDtoQueryHandler(IMemberService memberService, IMapper mapper)
            {
                _memberService = memberService;
                _mapper = mapper;
            }



            public async Task<MemberDto> Handle(GetByIdMemberDtoQuery request, CancellationToken cancellationToken)
            {
                var member =  await _memberService.GetById(request.Id);

                var result =  _mapper.Map<Member, MemberDto>(member);


                return await Task.FromResult(result);
            }
        }



    }

}
