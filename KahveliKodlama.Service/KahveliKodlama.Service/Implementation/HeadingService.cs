
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KahveliKodlama.Service.Implementation
{
    public class HeadingService : AsyncGenericRepository<Heading>, IHeadingService
    {
        public  async Task<List<Heading>> GetTopHeading()
        {
            var result = await GetAll();

            return  result
             .OrderByDescending(a => a.HeadingViews).Take(10).ToList();

           
        }
    }
}
