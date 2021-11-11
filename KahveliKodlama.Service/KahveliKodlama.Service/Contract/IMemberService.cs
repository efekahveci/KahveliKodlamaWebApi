using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Contract
{
    public interface IMemberService : IAsyncGenericRepository<Member>
    {
        Task<List<Member>> GetTopMembers();
    }
}
