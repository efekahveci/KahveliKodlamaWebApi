using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation
{
    public class CategoryService : AsyncGenericRepository<Category>, ICategoryService
    {
        public async Task<List<Category>> GetTopClickCategory()
        {
            var result = await GetAll();
            return result
               .OrderByDescending(c => c.CategoryClick).Take(10).ToList();
               
        }
    }
}
