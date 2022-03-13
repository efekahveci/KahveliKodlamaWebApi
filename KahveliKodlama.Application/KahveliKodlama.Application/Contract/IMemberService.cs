using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract
{
    public interface IMemberService : IAsyncGenericRepository<Member>
    {
        Task<List<Member>> GetTopMembers();
        Task<Member> UpdateMember(MemberDto member);

        Task<int> AddPointMember(Member member,int point);
        Task<Member> GetUser(string email);

      
    }
}
