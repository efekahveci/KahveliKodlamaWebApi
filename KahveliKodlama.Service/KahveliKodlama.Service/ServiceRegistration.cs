
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Service.Events;
using KahveliKodlama.Service.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace KahveliKodlama.Service;

public static class ServiceRegistration
{
    public static void AddServiceLayer(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddScoped<IMemberService, MemberService>();
        serviceCollection.AddScoped<IAuthService, AuthService>();
        serviceCollection.AddScoped<ICategoryService, CategoryService>();
        serviceCollection.AddScoped<IFileUpload, FileUpload>();
        serviceCollection.AddScoped<IContactService, ContactService>();
        serviceCollection.AddScoped<IHeadingService, HeadingService>();
        serviceCollection.AddScoped<IContentService, ContentService>();


        serviceCollection.AddSingleton<IEventPublisher, EventPublisher>();

        //Dynamic register

        Assembly.GetExecutingAssembly()
                 .GetTypes()
                 .Where(item => item.GetInterfaces()
                 .Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == typeof(IConsumer<>)) && !item.IsAbstract && !item.IsInterface)
                 .ToList()
                 .ForEach(assignedTypes =>
                 {
                     var serviceType = assignedTypes.GetInterfaces().First(i => i.GetGenericTypeDefinition() == typeof(IConsumer<>));
                     serviceCollection.AddScoped(serviceType, assignedTypes);
                 });
        //var consumers = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(type => typeof(IConsumer<>).
        //        IsAssignableFrom(type) && type.IsInterface).ToList();


        //foreach (var consumer in consumers)
        //{
        // consumers
        //.ForEach(typesToRegister =>
        //{
        //    typesToRegister.serviceTypes.ForEach(typeToRegister => services.AddScoped(typeToRegister, typesToRegister.assignedType));
        //});

        //    var deneme = consumer.FindInterfaces(consumer, );


        //    foreach (var findInterface in consumer.FindInterfaces((type, criteria) =>
        //    {
        //        var isMatch = type.IsGenericType && ((Type)criteria).IsAssignableFrom(type.GetGenericTypeDefinition());
        //        return isMatch;
        //    }, typeof(IConsumer<>)))
        //        serviceCollection.AddScoped(findInterface, consumer);

        serviceCollection.AddHealthChecks();


    }
}


