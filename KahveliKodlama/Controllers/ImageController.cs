using KahveliKodlama.Application.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ImageController : Controller
    {
        public static IWebHostEnvironment _environment;
        public static IFileUpload _fileUpload;
        public ImageController(IFileUpload fileUpload, IWebHostEnvironment environment)
        {
            _fileUpload = fileUpload;
            _environment= environment;
        }

        [HttpPost]
        public async Task<bool> PostImage(IFormFile file,int userId)
        {
            //var files = file;

            //if (files != null)
            //{
            //    string folderName = "Upload";

            //    string newPath = Path.Combine(_environment.ContentRootPath, folderName);

            //    if (!Directory.Exists(newPath))
            //    {
            //        Directory.CreateDirectory(newPath); 
            //    }

            //    foreach (var item in Request.Form.Files)
            //    {
            //        if(item.Length > 0)
            //        {
            //            byte[] p1 = null;
            //            using (var fs1 = item.OpenReadStream())
            //            {
            //                using (var ms1 = new MemoryStream())
            //                {
            //                    fs1.CopyTo(ms1);
            //                    p1 = ms1.ToArray(); 
            //                }
            //                string fileName=ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
            //                string fullPath=Path.Combine(newPath, fileName);
            //                using (var stream = new FileStream(fullPath,FileMode.Create))
            //                {
            //                    item.CopyTo (stream);
            //                }
            //            ////  //save operations 
            //            ////    Image image = new Image()
            //            ////    {
            //            ////        EntityId=id;
            //            ////    image = p1;

            //            ////    }
            //            ////_repository.save(image);
            //            }
            //        }
            //    }

            //}


            // var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            ClaimsPrincipal currentUser = this.User;
        
            //veritabanına kayıt ekleneceği zaman bir yerde tutulacak onay verilirse ilgili kayıt işlenecek.

            return await _fileUpload.Complate(file,currentUser);
        }

    }
}
