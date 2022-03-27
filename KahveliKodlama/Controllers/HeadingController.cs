using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Filters;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers;

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
    public  async Task<IActionResult> getAllDtoHeading()
    {
       


        var result = await _headingService.GetAllQuery.ToListAsync();



        if (result.Count > 0)
        {
            var retVal = _mapper.Map<List<Heading>, List<HeadingDto>>(result);

            

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk,  retVal));

        }

        return NoContent();
    }


    [HttpGet("getAll")]
    public async Task<IActionResult> GetAllHeading()
    {
        var result = await _headingService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
        }

        return NoContent();
    }

    [HttpGet("getTop")]
    public async Task<IActionResult> GetTop()
    {
        var result = await _headingService.GetTopHeading();

        if (result.Count > 0)
        {
            var retVal = _mapper.Map<List<Heading>, List<HeadingDto>>(result);
            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

        }

        return NoContent();
    }
    [HttpGet("getByIdDto/{id}")]
    public async Task<IActionResult> GetByIdDtoHeading(string id)
    {
        var result = await _headingService.GetById(id);
       

        if (result != null)
        {
            var retVal = _mapper.Map<Heading, HeadingDto>(result);
            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<HeadingDto>() { retVal }));

        }

        return NoContent();

    }


  // [Authorize("Admin")]

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetByIdHeading(string id)
    {
        var result = await _headingService.GetById(id);

        if (result != null)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
        }

        return NoContent();
    }

    [HttpGet("getSubHeading/{id}")]
    public async Task<IActionResult> GetSubHeading(string id)
    {
       


        var result = await _headingService.GetSubHeadings(id);



        if (result.Count > 0)
        {
            var retVal = _mapper.Map<List<Heading>, List<HeadingDto>>(result);



            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

        }

        return NoContent();
    }

    [HttpPost("addHeading")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [Authorize]
    public async Task<Heading> AddHeading([FromBody] HeadingDto heading)
    {

        var identity = HttpContext.User.Identity as ClaimsIdentity;

        IEnumerable<Claim> claims = identity.Claims;

        var userid = claims.FirstOrDefault(x => x.Type == "id").Value;

        heading.MemberId = Guid.Parse(userid);

        var retval = _mapper.Map<HeadingDto, Heading>(heading);

        await _headingService.Create(retval);
        return null;
    }

    [HttpPatch("updateHeading")]
    public async Task<ActionResult<Heading>> UpdateHeading([FromBody] Heading heading)
    {

        var result = await _headingService.GetById(heading.Id.ToString());


        if (ModelState.IsValid && result != null)
        {

            await _headingService.Update(heading);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

        }
        return NoContent();

    }
 

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHeading(string id)
    {

        if (ModelState.IsValid)
        {

            await _headingService.Delete(id);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<string>() { "Kullanıcı sistemden silindi." }));

        }
        return NoContent();
    }
}
