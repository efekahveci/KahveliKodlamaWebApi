using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;

public interface IHeadingService : IAsyncGenericRepository<Heading>
{
    Task<List<Heading>> GetTopHeading();

    Task<List<Heading>> GetSubHeadings(string categoryId);


}
