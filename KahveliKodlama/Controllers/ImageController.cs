using KahveliKodlama.Service.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {


        public static IFileUpload _fileUpload;
        public ImageController(IFileUpload fileUpload)
        {
            _fileUpload = fileUpload;

        }

        [HttpPost]
        public async Task<bool> PostImage(IFormFile file)
        {
            return await _fileUpload.Complate(file);
        }


    }
}
