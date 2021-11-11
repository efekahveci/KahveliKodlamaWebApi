using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Contract
{
    public interface IFileUpload
    {
        Task<bool> Complate(IFormFile file);
    }
}
