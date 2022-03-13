using FluentValidation.AspNetCore;
using KahveliKodlama.Application;
using KahveliKodlama.Application.Filters;
using KahveliKodlama.Persistence;
using KahveliKodlama.Service;
using KahveliKodlama.Service.Extensions;
using KahveliKodlama.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace KahveliKodlama
{
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


            services.AddServiceLayer(Configuration);
            services.AddApplicationLayer();
            services.AddPersistanceLayer(Configuration);
       
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
   
}
