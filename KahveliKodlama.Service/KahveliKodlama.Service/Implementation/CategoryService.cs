using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation;

public class CategoryService : AsyncGenericRepository<Category>, ICategoryService
{
    public async Task<Category> UpdateCategory(CategoryDto category)
    {
        var result = await GetById(category.Id.ToString());

        var retVal = result.Merge(category);

        await Update(retVal);

        return retVal;

    }
}
