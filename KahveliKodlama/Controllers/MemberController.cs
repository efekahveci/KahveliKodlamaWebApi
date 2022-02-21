using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.CQRS.Commands;
using KahveliKodlama.Application.CQRS.Commands.Members;
using KahveliKodlama.Application.CQRS.Queries.Members.GetByIdMember;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;

using KahveliKodlama.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Context;
//using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
//        [FromQuery], sorgu dizesinden değerler almaktır
//[FromRoute], rota verilerinden değerler almak içindir
//[FormForm], gönderilen form alanlarından değerler almak içindir
//[FromBody], istek gövdesinden değerler almaktır
//[FromHeader], HTTP başlıklarından değerler almak içindir
//[FromService], DI (Bağımlılık Enjeksiyonu) çözümleyicisi tarafından enjekte edilen değere sahip olacak


        // private readonly ILogger _log = Log.ForContext<MemberController>();
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        //private readonly ILogger<MemberController> _logger;
        //  private readonly ILogger _log;//For Context Specifies The Class Which The Log Is Intended For

        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IAsyncGenericRepository<Member> _repository;

        //servisleri ayıracaz base controller o şekilde yapılacak repo lar unit of work tan çağrılacak

        public MemberController(IMemberService memberService, IMapper mapper, IMediator mediator)
        {
            // _log = logger;
            _mapper = mapper;
            _memberService = memberService;
            _mediator = mediator;
            //_unitOfWork = unitOfWork;

            //_repository = _unitOfWork.GetRepository<Member>();
        }

        [HttpGet("getAllDto")]
        public async Task<IActionResult> GetAllDtoMember()
        {

           // var query = new GetAllMemberQuery();

          //  return await _mediator.Send(new GetAllMemberDtoQuery());


            //int a = 0;
            //var b = 5 / a;
            //var result = 

           

            //return retVal;


            var result = await _memberService.GetAll();

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
            //IQueryable çekme ile listeye çevirmenin farkı ne olur ?
            //var test = User.Identity.Name;

            //var resu
            ////Log.Warning($"Call selam getAll Method");
            ////Log.ForContext("user_name", User.Identity.Name).Warning($"Call {User.Identity.Name} getAll Method");
            ////   return await _mediator.Send(new GetAllMemberQuery());
            //return null;
            //var result = await _memberService.GetAll().ToListAsync();
            ////  throw new NotImplementedException();    
            //return  result;


            var result = await _memberService.GetAll();

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

            var test = claims.FirstOrDefault(x => x.Type == "id").Value;




            //return await _mediator.Send(new GetByIdMemberDtoQuery() { Id = id });

            ////var result = await _memberService.GetById(id);

            ////var retVal = _mapper.Map<Member, MemberDto>(result);

            ////return retVal;


            ////return await _mediator.Send(new GetByIdMemberDtoQuery(id));
            ///


            //var result = await _memberService.GetById(id,x=>x.Headings);

            var result = await _memberService.GetById(Convert.ToInt32(test),x=>x.Headings);


            if (result!=null)
            {
                var retVal = _mapper.Map<Member, MemberDto>(result);

                retVal.Image= retVal.Image.Substring(retVal.Image.LastIndexOf('\\') + 1);



                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));
            }

            return NoContent();
        }

        [HttpGet("getById/{id}")]
      //  
        public async Task<IActionResult> GetByIdMember(int id)
        {
            //var result = _memberService.GetById(id);

            //return result;

            //   var result = new GetByIdMemberQuery();

            //return await _mediator.Send(new GetByIdMemberQuery() { Id = id });

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

            //return await _memberService.GetTopMembers();

            ////var result = await _memberService.GetById(id);

            ////var retVal = _mapper.Map<Member, MemberDto>(result);

            ////return retVal;


            ////return await _mediator.Send(new GetByIdMemberDtoQuery(id));
            var result = await _memberService.GetTopMembers();

            if (result != null)
            {

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));
            }

            return NoContent();
        }
     
        

        [HttpPost("add")]
        [Authorize("SuperAdmin")]

        public async Task<IActionResult> AddMember([FromBody] MemberDto member)
        {

            ////return await _mediator.Send(new GetByIdMemberDtoQuery(id));
            ///

            var result = await _memberService.GetUser(member.Email);

            
            if (ModelState.IsValid && result==null)
            {

                result = _mapper.Map<MemberDto, Member>(member);

                await _memberService.Create(result);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

            }
            return NoContent();


        }

        [HttpPost("TC")]
        public async Task<IActionResult> CheckMember([FromBody] MernisDto member)
        {



            var client = new MernisTC.KPSPublicSoapClient(MernisTC.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.TCKNO), member.Name, member.Surname, member.Year);


           // return response.Body.TCKimlikNoDogrulaResult;

            

            var result = await _memberService.GetUser(member.Email);


            if (ModelState.IsValid && response.Body.TCKimlikNoDogrulaResult && result!=null)
            {

                //result = _mapper.Map<MemberDto, Member>(member);

                //await _memberService.Create(result);

                await _memberService.AddPointMember(result, 50);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validPoint, response.Body.TCKimlikNoDogrulaResult));

            }
            return NoContent();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateMember([FromBody] MemberDto member)
        {
            //memberdtoya dönüşecek
            //id point gibi bilgiler hacklenebilir mi ?
            // var retVal = await _memberService.GetById(member.Id);
            //var newValue = retVal.Merge(member);

            ////var result = _mapper.Map<MemberDto, Member>(member);


            //newValue.Point = retVal.Point;

            //await _memberService.Update(newValue);

            //_memberService.
            //await _memberService.UpdateMember(member);

            //return Ok(member);



            var result = await _memberService.GetUser(member.Email);


            if (ModelState.IsValid && result != null)
            {

                await _memberService.UpdateMember(member);

                return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

            }
            return NoContent();
        }



        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteMember(int id)
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
