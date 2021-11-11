using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Context;
using KahveliKodlama.Service.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IQueryable<Member> GetAll()
        {
            var result = _memberService.GetAll();

            return result;
        }

        [HttpPost]
        public async Task<Member> AddMember([FromBody] Member member)
        {
            await _memberService.Create(member);
            return member;
        }

        [HttpPut]
        public async Task<ActionResult<Member>> UpdateMember([FromBody] Member member)
        {
            
             await _memberService.Update(member);
            return Ok(member);
            
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMember(int id)
        {
           
            await _memberService.Delete(id);
            return Ok();
        }
    }
}
