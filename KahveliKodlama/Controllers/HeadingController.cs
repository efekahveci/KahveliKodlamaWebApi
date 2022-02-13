using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Service.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadingController : ControllerBase
    {

        private readonly IHeadingService _headingService;
        private readonly IMapper _mapper;

        public HeadingController(IHeadingService headingService,IMapper mapper)
        {
            _headingService = headingService;
            _mapper = mapper;
        }

        [HttpGet("getAllDto")]
        public ActionResult<List<HeadingDto>> getAllDto()
        {
            var result = _headingService.GetAll();

            var retVal = _mapper.Map<Task<List<Heading>>,List<HeadingDto>>(result);

            return Ok(retVal);
        }
   

        [HttpGet("getAll")]
        public ActionResult<IQueryable<Heading>> GetAll()
        {
            var result = _headingService.GetAll();

            return Ok(result);
        }

        [HttpGet("getTop")]
        public Task<List<Heading>> GetTop()
        {
            var result = _headingService.GetTopHeading();

            return result;
        }
        [HttpGet("getByIdDto/{id}")]
        public async Task<HeadingDto> GetByIdDto(int id)
        {
            var result = await _headingService.GetById(id);

            var retval = _mapper.Map<Heading, HeadingDto>(result);

            return retval;
        }


      // [Authorize("Admin")]

        [HttpGet("getById/{id}")]
        public Task<Heading> GetById(int id)
        {
            var result = _headingService.GetById(id);

            return result;
        }

        [HttpPost("addHeading")]
        public async Task<Heading> AddHeading([FromBody] HeadingDto heading)
        {

            var retval = _mapper.Map<HeadingDto, Heading>(heading);

            await _headingService.Create(retval);
            //return heading;
            return null;
        }

        [HttpPatch("updateHeading")]
        public async Task<ActionResult<Heading>> UpdateHeading([FromBody] Heading heading)
        {

            await _headingService.Update(heading);
            return Ok(heading);

        }
     

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeading(int id)
        {

            await _headingService.Delete(id);
            return Ok();
        }
    }
}
