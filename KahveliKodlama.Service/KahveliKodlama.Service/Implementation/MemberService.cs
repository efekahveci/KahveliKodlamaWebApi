using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Context;
using KahveliKodlama.Persistence.Repositories;
using KahveliKodlama.Service.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation
{
    public class MemberService : AsyncGenericRepository<Member>, IMemberService
    {
       

        public async Task<List<Member>> GetTopMembers()
        {

            return await GetAll()
               .OrderByDescending(c => c.Name)
               .ToListAsync();
        }
    }
}
