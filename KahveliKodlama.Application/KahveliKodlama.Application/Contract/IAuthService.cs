using KahveliKodlama.Application.CQRS.Commands.Authenticate.AddRole;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Login;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.Register;
using KahveliKodlama.Application.CQRS.Commands.Authenticate.RegisterAdmin;
using KahveliKodlama.Domain.Auth;
using KahveliKodlama.Domain.Entities;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Contract;

public interface IAuthService
{
    Task<ResponseResult> GetUsersAsync();
    Task<ResponseResult> Login(LoginCommandRequest model);
    Task<ResponseResult> Register(RegisterCommandRequest model);
    Task<ResponseResult> RegisterAdmin(RegisterAdminCommandRequest model);
    Task<ResponseResult> AddRole(AddRoleCommandRequest model);
    Task<ResponseResult> PasswordReset(ResetPassViewModel model);
    Task<ResponseResult> UpdatePassword(UpdatePassViewModel model, string userId, string token);
    Task<ResponseResult> Logout();

} 
