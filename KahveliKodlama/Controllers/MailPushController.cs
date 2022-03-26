using AutoMapper;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MailPushController : ControllerBase
{
    private readonly IEmailService _service;
    private readonly IMapper _mapper;

    public MailPushController(IEmailService service,IMapper mapper)
    {
        _mapper = mapper;
        _service = service;
    }



    [HttpPost("push")]

    public async Task<IActionResult> PushMail([FromBody] MailDto email)
    {
        var result = _mapper.Map<MailDto, Mail>(email);


        var retVal = await _service.SendPushEmail(result);

        if (retVal==true)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<bool>() { retVal }));

        }

        return NoContent();


    }



}
