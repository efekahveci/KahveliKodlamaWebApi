using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContentController : ControllerBase
{
    private readonly IContentService _contentService;
    private readonly IMapper _mapper;

    public ContentController(IContentService contentService, IMapper mapper)
    {
        _contentService = contentService;
        _mapper = mapper;
    }

    [HttpGet("getAllDto")]
    public async Task<IActionResult> GetAllDtoContent()
    {
        var result = await _contentService.GetAllQuery.ToListAsync();



        if (result.Count > 0)
        {
            var retVal = _mapper.Map<List<Content>, List<ContentDto>>(result);
            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

        }

        return NoContent();
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAllContent()
    {
        var result = await _contentService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
        }

        return NoContent();
    }

    [HttpGet("getByIdDto/{id}")]
    public async Task<IActionResult> GetByIdDtoContent(string id)
    {



        var result = await _contentService.GetById(id);


        if (result != null)
        {
            var retVal = _mapper.Map<Content, ContentDto>(result);


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<ContentDto>() { retVal }));
        }

        return NoContent();
    }

    [HttpGet("getByIdHeadingContent/{id}")]
    public async Task<IActionResult> GetByIdHeadingContent(string id)
    {



        var result = await _contentService.GetByIdHeadingContent(id);


        if (result != null)
        {
            var retVal = _mapper.Map<List<Content>, List<ContentDto>>(result);


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));
        }

        return NoContent();
    }

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetByIdContent(string id)
    {
        var result = await _contentService.GetById(id);

        if (result != null)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
        }

        return NoContent();
    }
    [HttpPost("add")]

    [HttpPost]
    public async Task<IActionResult> AddContent([FromBody] ContentDto content)
    {

        var result  = _mapper.Map<ContentDto, Content>(content);


        if (result != null)
        {

           

            await _contentService.Create(result);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<Content>() { result }));

        }


        return NotFound(new ResponseResult(Domain.Enum.ResponseCode.Not_Found, MessageHelper.validError, new List<string> { "Kayıt Daha önce eklenmiş" }));


    }

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateContent([FromBody] Content content)
    {


        if (ModelState.IsValid)
        {

            await _contentService.Update(content);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<Content>() { content}));

        }
        return NoContent();

    }
    [HttpPatch("Update")]
    public async Task<IActionResult> UpdateContent([FromBody] ContentDto content)
    {

        if (ModelState.IsValid)
        {   

            await _contentService.UpdateContent(content);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<ContentDto>() { content}));

        }
        return NoContent();

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContent(string id)
    {


        if (ModelState.IsValid)
        {

            await _contentService.Delete(id);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<string>() { "Kullanıcı sistemden silindi." }));

        }
        return NoContent();
    }
}
