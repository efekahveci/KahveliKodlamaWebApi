using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract
{
    public interface IFileUpload
    {
        Task<bool> Complate(IFormFile file, string userName);
    }
}
