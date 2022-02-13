using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract
{
    public interface IHeadingService : IAsyncGenericRepository<Heading>
    {
        Task<List<Heading>> GetTopHeading();
    }
}
