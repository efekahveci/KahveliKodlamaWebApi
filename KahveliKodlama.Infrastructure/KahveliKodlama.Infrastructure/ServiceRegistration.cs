using KahveliKodlama.Infrastructure.Contract;
using KahveliKodlama.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;




namespace KahveliKodlama.Infrastructure;

public static class ServiceRegistration
{
    public static void AddInfrastructureLayer(this IServiceCollection serviceCollection)
    {
       
         serviceCollection.AddScoped<IEmailService, EmailService>();
    }

  

}
