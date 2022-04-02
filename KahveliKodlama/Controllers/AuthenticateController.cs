using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Login;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.RegisterAdmin;
using KahveliKodlama.Application.CQRS.Queries.Authenticate;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers;

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
    public async Task<IActionResult> GetUsersAsync()
    {
        var result = await _mediator.Send(new GetUsersQueryRequest());

        if (result.Data!=null)
        {
            return Ok(result);
        }

        return NoContent();

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



}
