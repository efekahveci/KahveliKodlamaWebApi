using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;

namespace KahveliKodlama.Application.Contract;

public interface IContactService : IAsyncGenericRepository<Contact>
{
}
