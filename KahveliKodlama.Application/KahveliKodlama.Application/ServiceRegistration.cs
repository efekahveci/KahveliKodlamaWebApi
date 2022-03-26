


using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Mapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace KahveliKodlama.Application;

public static class ServiceRegistration
{
    public static void AddApplicationLayer(this IServiceCollection serviceCollection)
    {
        var assm = Assembly.GetExecutingAssembly();


        serviceCollection.AddAutoMapper(typeof(MappingProfile));
        serviceCollection.AddMediatR(assm);
     

    }


}
