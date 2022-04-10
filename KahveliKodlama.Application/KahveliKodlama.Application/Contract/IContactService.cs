using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Entities;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;

public interface IContactService : IAsyncGenericRepository<Contact>
{
    Task<Contact> UpdateContact(ContactDto contactDto);
}
