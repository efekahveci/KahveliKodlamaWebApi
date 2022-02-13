using KahveliKodlama.Application.Interfaces.Repositories;

using KahveliKodlama.Application.Contract;
using KahveliKodlama.Service.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceLayer(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {

            var assm = Assembly.GetExecutingAssembly();

            //serviceCollection.AddScoped<IAsyncGenericRepository, AsyncGenericRepository>();
            serviceCollection.AddScoped<IMemberService, MemberService>();
            serviceCollection.AddScoped<IAuthService, AuthService>();
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IFileUpload, FileUpload>();
            serviceCollection.AddScoped<IContactService, ContactService>();
            serviceCollection.AddScoped<IHeadingService, HeadingService>();
            serviceCollection.AddScoped<IContentService, ContentService>();
         //   serviceCollection.AddMediatR(typeof(Startup));
        }
    }
}


