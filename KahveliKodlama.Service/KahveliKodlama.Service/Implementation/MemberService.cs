using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation;

public class MemberService : AsyncGenericRepository<Member>, IMemberService
{
    public async Task<int> AddPointMember(Member member,int point)
    {
     
        member.Point += point;

        await Update(member);

        return member.Point;    
    }

    public async Task<List<Member>>GetTopMembers()
    {

        var orderByDescendingResult = await GetAllQuery.ToListAsync();

        return orderByDescendingResult
           .OrderByDescending(c => c.Point).Take(10).ToList();               
    }

    public async Task<Member> GetUser(string email)
    {
        var query = GetAllQuery.Where(x => x.Email == email).AsQueryable();

        var result = await query.ToListAsync();

        return  result.FirstOrDefault(x => x.Email == email);
                    
        
    }

  

    public async Task<Member> UpdateMember(MemberDto member)
    {
        var result = await GetUser(member.Email);

        var retVal=result.Merge(member);

        if (member.GetType().GetProperties()
                       .All(p => p.GetValue(member) != null) && !result.IsVerifiedInfo)
        {
            retVal.IsVerifiedInfo = true;
            retVal.Point += 50;
        }

        await Update(retVal);

        return retVal;

    }
}
