using KahveliKodlama.Application.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers;

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
        _environment = environment;
    }


    [Authorize]

    [HttpPost]
    public async Task<bool> PostImage(IFormFile file, int userId)
    {

        var identity = HttpContext.User.Identity as ClaimsIdentity;

        IEnumerable<Claim> claims = identity.Claims;

        string userName = claims.FirstOrDefault(x => x.Type == "username").Value;
        string email = claims.FirstOrDefault(y => y.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").Value;


        var result = userName + "+++" + email;

        return await _fileUpload.Complate(file, result);
    }

}
