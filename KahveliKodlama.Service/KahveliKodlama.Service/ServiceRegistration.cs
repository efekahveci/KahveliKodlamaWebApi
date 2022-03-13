
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Service.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace KahveliKodlama.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceLayer(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {

            serviceCollection.AddScoped<IMemberService, MemberService>();
            serviceCollection.AddScoped<IAuthService, AuthService>();
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IFileUpload, FileUpload>();
            serviceCollection.AddScoped<IContactService, ContactService>();
            serviceCollection.AddScoped<IHeadingService, HeadingService>();
            serviceCollection.AddScoped<IContentService, ContentService>();

            serviceCollection.AddHealthChecks();


        }
    }
}


