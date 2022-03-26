using FluentValidation.AspNetCore;
using KahveliKodlama.Application;
using KahveliKodlama.Application.Filters;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure;
using KahveliKodlama.Persistence;
using KahveliKodlama.Service;
using KahveliKodlama.Service.Extensions;
using KahveliKodlama.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace KahveliKodlama;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers().AddFluentValidation();

        //400 bad request cevaplarýný customize eder

        services.Configure<ApiBehaviorOptions>(o =>
        {
            o.InvalidModelStateResponseFactory = actionContext =>
                new BadRequestObjectResult(new ResponseResult(Domain.Enum.ResponseCode.Bad_Request, MessageHelper.validError, 
                actionContext.ModelState.SelectMany(x => x.Value.Errors)
                           .Select(y => y.ErrorMessage)
                           .ToList()));
        });


        services.AddServiceLayer();
        services.AddApplicationLayer();
        services.AddPersistanceLayer(Configuration);
        services.AddInfrastructureLayer();


        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddCors(options =>
        {
            options.AddPolicy("MyPolicy",
                builder => builder.SetIsOriginAllowed((host) => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
        });


        services.AddScoped<ValidationFilterAttribute>(); //ValidFilter

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        app.ConfigureRequestPipeline();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();

        }

        app.UseHttpsRedirection();
        app.UseSerilogRequestLogging(); // <-- Add this line

        app.UseRouting();

        app.UseStaticFiles();

        app.UseCors("MyPolicy");
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseCustomHealthCheck();


        app.UseExceptionMiddleware();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

    }
  
}

