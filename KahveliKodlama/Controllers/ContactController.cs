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
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public ContactController(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    [HttpGet("getAllDto")]
    public async Task<IActionResult> GetAllDtoContact()
    {
        var result = await _contactService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {
            var retVal = _mapper.Map<List<Contact>, List<ContactDto>>(result);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

        }

        return NotFound();
    }
    [HttpGet("getAll")]
    public async Task<IActionResult> GetAllContact()
    {

        var result = await _contactService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

        }

        return NotFound();
    }

    [HttpGet("getByIdDto/{id}")]
    public async Task<IActionResult> GetByIdDtoContact(string id)
    {
        var result = await _contactService.GetById(id);


        if (result != null)
        {
            var retVal = _mapper.Map<Contact, ContactDto>(result);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<ContactDto> { retVal }));
        }

        return NotFound();
    }
    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetByIdContact(string id)
    {
        var result = await _contactService.GetById(id);


        if (result != null)
        {


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<Contact> { result }));
        }

        return NotFound();
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddContact([FromBody] ContactDto contact)
    {

        if (ModelState.IsValid)
        {

            var result = _mapper.Map<ContactDto, Contact>(contact);

            await _contactService.Create(result);


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk));

        }


        return NotFound(new ResponseResult(Domain.Enum.ResponseCode.Not_Found, MessageHelper.validError));

    }

    [HttpPut("update")]
    public async Task<ActionResult<Contact>> UpdateContact([FromBody] ContactDto contact)
    {

        if (ModelState.IsValid)
        {

            await _contactService.UpdateContact(contact);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk));

        }
        return NotFound();

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(string id)
    {

        if (ModelState.IsValid)
        {

            await _contactService.Delete(id);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk));

        }
        return NotFound();
    }
}
