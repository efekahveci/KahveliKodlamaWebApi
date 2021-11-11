using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Service.Contract;
using KahveliKodlama.Service.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadingController : ControllerBase
    {

        private readonly IHeadingService _headingService;

        public HeadingController(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        [HttpGet]
        public IQueryable<Heading> GetAll()
        {
            var result = _headingService.GetAll();

            return result;
        }
    }
}
