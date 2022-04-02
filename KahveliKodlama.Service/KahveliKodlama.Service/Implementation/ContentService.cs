

using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation;

public class ContentService : AsyncGenericRepository<Content>,IContentService
{
   

   
    public async Task<Content> UpdateContent(ContentDto contentDto)
    {
      

        var result = await GetById(contentDto.Id.ToString());

        var retVal = result.Merge(contentDto);

        await Update(retVal);

        return retVal;

    }

    public async Task<List<Content>> GetByIdHeadingContent(string id)
    {

        var result = await GetAllQuery.Where(x => x.HeadingId == Guid.Parse(id)).ToListAsync();

        return result;
    }

    
}
