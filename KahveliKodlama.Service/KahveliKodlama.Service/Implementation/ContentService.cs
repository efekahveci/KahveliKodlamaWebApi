using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;

namespace KahveliKodlama.Service.Implementation
{
    public class ContentService : AsyncGenericRepository<Content>,IContentService
    {
    }
}
