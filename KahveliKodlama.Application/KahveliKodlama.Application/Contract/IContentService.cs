using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;

public interface IContentService : IAsyncGenericRepository<Content>
{
    Task<Content> UpdateContent(ContentDto member);

    Task<List<Content>> GetByIdHeadingContent(string id);
}
