using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;

public interface IFileUpload
{
    Task<bool> Complate(IFormFile file, string userName);
}
