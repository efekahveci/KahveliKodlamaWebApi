using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;

public interface ICategoryService : IAsyncGenericRepository<Category>
{
    Task<Category> UpdateCategory(CategoryDto category);

}
