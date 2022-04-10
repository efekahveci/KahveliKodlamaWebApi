using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Persistence.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;


namespace KahveliKodlama.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistanceLayer(this IServiceCollection serviceCollection, IConfiguration configuration = null)
    {
        //                      add-migration -Context KahveliContext
        //                      add-migration -Context IdentityContext
        //                      update-database -Context KahveliContext
        //                      update-database -Context IdentityContext


        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IEngine, KahveliContextEngine>();

        serviceCollection.AddDbContext<KahveliContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        serviceCollection.AddDbContext<IdentityContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


        // For Identity  
        serviceCollection.AddIdentity<AppUser, IdentityRole>(_ =>
        {
            //_.Password.RequiredLength = 5; //En az kaç karakterli olması gerektiğini belirtiyoruz.
            _.Password.RequireNonAlphanumeric = false; //Alfanumerik zorunluluğunu kaldırıyoruz.
            _.Password.RequireLowercase = false; //Küçük harf zorunluluğunu kaldırıyoruz.
            _.Password.RequireUppercase = false; //Büyük harf zorunluluğunu kaldırıyoruz.
            _.Password.RequireDigit = false; //0-9 arası sayısal karakter zorunluluğunu kaldırıyoruz.
            _.Password.RequiredLength = 3;



        })
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders();



        // Adding Authentication  
        serviceCollection.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })

        // Adding Jwt Bearer  
        .AddJwtBearer(options =>
        {
            options.SaveToken = true;
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateLifetime = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = configuration["JWT:ValidAudience"],
                ValidIssuer = configuration["JWT:ValidIssuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"])),
                ValidateIssuerSigningKey = true,
                ClockSkew = TimeSpan.Zero


            };
        });
        serviceCollection.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromSeconds(1);
            options.LoginPath = "/api/Authenticate/login";
            options.LogoutPath = "/api/Authenticate/logout";
        });

    }

    public static void ConfigureRequestPipeline(this IApplicationBuilder application)
    {
        EngineContext.Current.ConfigureRequestPipeline(application);
    }

}
