using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;

namespace KahveliKodlama.Service.Implementation
{
    public class CategoryService : AsyncGenericRepository<Category>, ICategoryService
    {
    
    }
}
