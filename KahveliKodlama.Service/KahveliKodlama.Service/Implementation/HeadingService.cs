
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KahveliKodlama.Service.Implementation;

public class HeadingService : AsyncGenericRepository<Heading>, IHeadingService
{
    public async Task<List<Heading>> GetSubHeadings(string categoryId)
    {
        var result = await GetAllQuery.Where(x=>x.CategoryId==Guid.Parse(categoryId)).ToListAsync();

        return result;
    }

    public  async Task<List<Heading>> GetTopHeading()
    {
        var result = await GetAllQuery.ToListAsync(); 

        return  result
         .OrderByDescending(a => a.HeadingViews).Take(10).ToList();

       
    }



}
