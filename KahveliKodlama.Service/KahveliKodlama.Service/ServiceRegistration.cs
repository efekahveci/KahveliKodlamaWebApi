using KahveliKodlama.Service.Contract;
using KahveliKodlama.Service.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceLayer(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {

            serviceCollection.AddScoped<IMemberService, MemberService>();
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IFileUpload, FileUpload>();
            serviceCollection.AddScoped<IContactService, ContactService>();
            serviceCollection.AddScoped<IHeadingService, HeadingService>();

        }
    }
}
