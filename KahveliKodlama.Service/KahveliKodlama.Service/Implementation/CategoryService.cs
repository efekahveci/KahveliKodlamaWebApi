﻿using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using KahveliKodlama.Service.Contract;
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
        
    }
}
