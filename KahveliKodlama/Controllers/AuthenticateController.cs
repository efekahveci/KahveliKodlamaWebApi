using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

using KahveliKodlama.Domain.Auth;

using Microsoft.AspNetCore.Cors;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;

using MediatR;
using KahveliKodlama.Application.CQRS.Queries.Authenticate;
using KahveliKodlama.Application.CQRS.Commands.Authenticate;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Login;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Register_Admin;
using Microsoft.AspNetCore.Authorization;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole;
using System.Security.Claims;
using System.Linq;
using System;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    [EnableCors("MyPolicy")]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMediator _mediator;
      
        public AuthenticateController(IAuthService authService, IMediator mediator)
        {
            _authService = authService;
            _mediator = mediator;
      
        }

        [HttpGet("getUsers")]
        [Authorize]

        public async Task<IActionResult> GetUsersAsync()
        {

     
         //   var identity = HttpContext.User.Identity as ClaimsIdentity;

           // IEnumerable<Claim> claims = identity.Claims;

         //   var test = claims.FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid").Value;

            // or
           // identity.FindFirst("ClaimName").Value;
            // claims?.FirstOrDefault(x => x.Type.Equals("UserName", StringComparison.OrdinalIgnoreCase))?.Value 
            //    var id = claimsIdentity.Claims.Select(c =>
            //new
            //{
            //    Type = c.Type,
            //    Value = c.Value
            //});

            // var test =  claimsIdentity.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid", StringComparison.OrdinalIgnoreCase);

            //var member = claimsIdentity.Where(c => c.Type == ClaimTypes.Sid)
            //     .Select(c => c.Value).SingleOrDefault();
            // var claims = ClaimsPrincipal.Current.Identities;

            var result = await _mediator.Send(new GetUsersQueryRequest());

            if (result.Data!=null)
            {
                return Ok(result);
            }

            return Unauthorized();

        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
         
          return Ok(await _authService.Logout()); 

        }

        [HttpPost]
        [Route("add-role")]
        [Authorize(Roles = "SuperAdmin")]
        //Demo parametreleri
        public async Task<IActionResult> AddRole([FromBody] AddRoleCommandRequest model)
        {

            if (ModelState.IsValid)
            {
                return Ok(await _mediator.Send(model));

            }

            return Unauthorized();

        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommandRequest model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _mediator.Send(model));

            }

            return NotFound();

        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterCommandRequest model)
        {


            if (ModelState.IsValid)
            {
                return Ok(await _mediator.Send(model));

            }

            return NotFound();

        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterAdminCommandRequest model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _mediator.Send(model));

            }

            return NotFound();

        }

        [HttpPost]
        [Route("PasswordReset")]
        public async Task<ResponseResult> PasswordReset([FromBody]  ResetPassViewModel model)
        {
            return await _authService.PasswordReset(model);

        }

   
        //[HttpPost("UpdatePassword/{userId}/{id}")]
  
        //public async Task<ResponseResult> UpdatePassword([FromBody] UpdatePassViewModel model, [FromBody] string userId, string token)
        //{
        //    return await _authService.UpdatePassword(model);

        //}
    }
}
