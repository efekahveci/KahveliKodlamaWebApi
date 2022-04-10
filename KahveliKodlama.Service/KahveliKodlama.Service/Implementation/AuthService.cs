using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Login;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.RegisterAdmin;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation;

public class AuthService : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration;
    private readonly IdentityContext _context;
    private readonly IMemberService _memberService;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IEventPublisher _publish;



    public AuthService(IEventPublisher publish, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IMemberService memberService, SignInManager<AppUser> signInManager)
    {
        _publish = publish;
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
        _context = EngineContext.Current.Resolve<IdentityContext>();
        _memberService = memberService;
        _signInManager = signInManager;
    }

    public async Task<ResponseResult> AddRole(AddRoleCommandRequest model)
    {


        //Canlıda kapatılacak
        await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        await _roleManager.CreateAsync(new IdentityRole("Admin"));
        await _roleManager.CreateAsync(new IdentityRole("Member"));
        await _roleManager.CreateAsync(new IdentityRole("Visitor"));



        if (!await _roleManager.RoleExistsAsync(model.Rolename))
        {

            await _roleManager.CreateAsync(new IdentityRole(model.Rolename));
            return new ResponseResult(Domain.Enum.ResponseCode.OK, "Yeni Rol Eklendi.");


        }

        else
            return new ResponseResult(Domain.Enum.ResponseCode.OK, "Rol Daha Önce Eklenmiş.");



    }

    public async Task<ResponseResult> GetUsersAsync()
    {
        return new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, await _context.Users.ToListAsync());
    }

    public async Task<ResponseResult> Login(LoginCommandRequest model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);
        var member = await _memberService.GetUser(model.Email);

        if (user != null &&
            await _userManager.CheckPasswordAsync(user, model.Password))
        {
            var userRoles = await _userManager.GetRolesAsync(user);


            var authClaims = new List<Claim>
            {
                new Claim("username", user.UserName),
                new Claim("email", user.Email),


                new Claim("role", userRoles[0]),
                new Claim("id", member.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };

            //foreach (var userRole in userRoles)
            //{
            //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            //}

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(

                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddSeconds(100000),
                claims: authClaims,
                notBefore: DateTime.Now,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                ); ;

            var strToken = new JwtSecurityTokenHandler().WriteToken(token);


            return new ResponseResult(Domain.Enum.ResponseCode.OK, "Giriş Başarılı.", new List<string>() { strToken });


        }
        return new ResponseResult(Domain.Enum.ResponseCode.Unauthorized, MessageHelper.validOk, new List<string>() { "Kullanıcı Adı veya Parola Hatalı." });
    }


    public async Task<ResponseResult> Logout()
    {

        await _signInManager.SignOutAsync();

        return new ResponseResult(Domain.Enum.ResponseCode.OK, "Çıkış Yapıldı.");
    }

    public async Task<ResponseResult> Register(RegisterCommandRequest model)
    {

        var userExists = await _userManager.FindByEmailAsync(model.Email);

        if (userExists != null)
            return new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<string>() { "Sistemde bu e-posta ile kayıtlı kullanıcı mevcut." });

        AppUser user = new AppUser()
        {
            Email = model.Email,
            SecurityStamp = Guid.NewGuid().ToString(),
            UserName = model.Username,


        };

        var result = await _userManager.CreateAsync(user, model.Password);



        if (!result.Succeeded)
            return new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result.Errors);

        await _roleManager.CreateAsync(new IdentityRole("Member"));
        await _userManager.AddToRoleAsync(user, "Member");
        _publish.PublishAsync(user);

        return new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<string>() { "Başarıyla kayıt olundu." });



    }

    public async Task<ResponseResult> RegisterAdmin(RegisterAdminCommandRequest model)
    {
        var userExists = await _userManager.FindByEmailAsync(model.Email);


        if (userExists != null)
            return new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<string>() { "Bu kallanıcı kayıtlı." });

        if (model.Key == "kahvelikodlama")
        {
            AppUser user = new AppUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username


            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return new ResponseResult(Domain.Enum.ResponseCode.OK, "Hata");
            await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            var results = await _userManager.AddToRoleAsync(user, "SuperAdmin");

            if (result.Succeeded)
            {
                return new ResponseResult(Domain.Enum.ResponseCode.OK, "Başarılı");

            }
            else
                return new ResponseResult(Domain.Enum.ResponseCode.OK, "Rol Bulunamadı.");


        }
        else
            return new ResponseResult(Domain.Enum.ResponseCode.No_Content, "Yetkisiz istek");
    }


}
