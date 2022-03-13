using AutoMapper;
using KahveliKodlama.API.Filters;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Validators;
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

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    { 
        
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;

        public MemberController(IMemberService memberService, IMapper mapper)
        {
          
            _mapper = mapper;
            _memberService = memberService;

        }

        [HttpGet("getAllDto")]
        public async Task<IActionResult> GetAllDtoMember()
        {


            var result = await _memberService.GetAllQuery.ToListAsync();

            if (result.Count>0)
            {
                var retVal = _mapper.Map<List<Member>, List<MemberDto>>(result);
                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

            }

            return NoContent();


        }

      
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllMember()
        {

            var result = await _memberService.GetAllQuery.ToListAsync();

            if (result.Count > 0)
            {
           
                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK,MessageHelper.validOk,result));
            }

            return NoContent();
        }

        [HttpGet("getByIdDto")]
        
        public async Task<IActionResult> GetByIdDtoMember()
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;

            IEnumerable<Claim> claims = identity.Claims;

            var userid = claims.FirstOrDefault(x => x.Type == "id").Value;

            var result = await _memberService.GetByIdInc(userid, x=>x.Headings);


            if (result!=null)
            {
                var retVal = _mapper.Map<Member, MemberDto>(result);

                retVal.Image= retVal.Image.Substring(retVal.Image.LastIndexOf('\\') + 1);

                

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk,new List<MemberDto>() { retVal }));
            }

            return NoContent();
        }

        [HttpGet("getById/{id}")]
       
        public async Task<IActionResult> GetByIdMember(string id)
        {
            var result = await _memberService.GetById(id);

            if (result != null)
            {

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
            }

            return NoContent();
        }

        [HttpGet("getTop")]
        public async Task<IActionResult> GetTopMembers()
        {
            var result = await _memberService.GetTopMembers();

            if (result != null)
            {

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
            }

            return NoContent();
        }
     
        

        [HttpPost("add")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]


        public async Task<IActionResult> AddMember([FromBody]  MemberDto member)
        {
         
            //yeni

            var result = await _memberService.GetUser(member.Email);


            if (result==null)
            {

                result = _mapper.Map<MemberDto, Member>(member);

                await _memberService.Create(result);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<Member>() { result }));

            }


            return NotFound(new ResponseResult(Domain.Enum.ResponseCode.Not_Found, MessageHelper.validError,new List<string> { "efe"}));


        }

        [HttpPost("TC")]
        public async Task<IActionResult> CheckMember([FromBody] MernisDto member)
        {

            var client = new MernisTC.KPSPublicSoapClient(MernisTC.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.TCKNO), member.Name, member.Surname, member.Year);            

            var result = await _memberService.GetUser(member.Email);


            if (ModelState.IsValid && response.Body.TCKimlikNoDogrulaResult && result!=null)
            {

                await _memberService.AddPointMember(result, 50);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validPoint, response.Body.TCKimlikNoDogrulaResult));

            }
            return NoContent();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateMember([FromBody] MemberDto member)
        {

            var result = await _memberService.GetUser(member.Email);


            if (ModelState.IsValid && result != null)
            {

                await _memberService.UpdateMember(member);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

            }
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteMember(string id)
        {


            if (ModelState.IsValid)
            {

                await _memberService.Delete(id);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<string>() { "Kullanıcı sistemden silindi."}));

            }
            return NoContent();
        }

    }
}
