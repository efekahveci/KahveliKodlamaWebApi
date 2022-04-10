using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Repositories;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation;

public class ContactService : AsyncGenericRepository<Contact>, IContactService
{
    public async Task<Contact> UpdateContact(ContactDto contactDto)
    {
        var result = await GetById(contactDto.Id.ToString());

        var retVal = result.Merge(contactDto);

        await Update(retVal);

        return retVal;

    }
}
