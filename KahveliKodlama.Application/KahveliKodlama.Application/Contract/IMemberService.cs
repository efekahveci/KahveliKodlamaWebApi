using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract
{
    public interface IMemberService : IAsyncGenericRepository<Member>
    {
        Task<ResponseResult> GetTopMembers();
        Task<Member> UpdateMember(MemberDto member);

        Task<int> AddPointMember(Member member,int point);
        Task<Member> GetUser(string email);

      
    }
}
