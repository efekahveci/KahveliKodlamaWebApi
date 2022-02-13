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
     public class GetByIdMemberQuery : IRequest<Member>
        {
        public int Id { get; set; }

        public class ByMemberQueryHandler : IRequestHandler<GetByIdMemberQuery, Member>
        {
            private readonly IMemberService _memberService;

            public ByMemberQueryHandler(IMemberService memberService, IMapper mapper)
            {
                _memberService = memberService;
          
            }



            public async Task<Member> Handle(GetByIdMemberQuery request, CancellationToken cancellationToken)
            {
                var member = await _memberService.GetById(request.Id);

           


                return await Task.FromResult(member);
            }
        }
    }
    
}