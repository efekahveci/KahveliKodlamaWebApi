using KahveliKodlama.Application;
using KahveliKodlama.Infrastructure;
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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddServiceLayer(Configuration);
            services.AddApplicationLayer();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddPersistanceLayer(Configuration);
            services.AddHealthChecks();

            //services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            //{

            //    //  builder.WithOrigins("https://localhost:1453", "http://localhost:1453").AllowAnyMethod().AllowAnyHeader())
            //    //  builder.WithOrigins("https://*.example.com").SetIsOriginAllowedToAllowWildcardSubdomains().AllowAnyHeader().AllowAnyMethod()

            //    builder.WithOrigins("http://localhost:4200/").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true); // allow any origin
            //}));

            services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy",
                    builder => builder.SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            //services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin()
            //                                                                   .AllowAnyMethod()
            //                                                                   .AllowAnyHeader()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseRouting();

            app.UseStaticFiles();



            app.UseCors("MyPolicy");
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseSerilogRequestLogging(options =>
            //           {
            //               options.EnrichDiagnosticContext = PushSeriLogProperties;
            //           });

            //     app.UseMiddleware<LogUserNameMiddleware>();



            //app.UseCors("MyPolicy");
            app.UseCustomHealthCheck();

            //  app.UseMiddleware<ExceptionMiddleware>();

            app.UseExceptionMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
        //public void PushSeriLogProperties(IDiagnosticContext diagnosticContext, HttpContext httpContext)
        //{
        //    diagnosticContext.Set("user_name", httpContext.User.Identity?.Name);
        //}
    }
    //public class LogUserNameMiddleware
    //{
    //    private readonly RequestDelegate next;

    //    public LogUserNameMiddleware(RequestDelegate next)
    //    {
    //        this.next = next;
    //    }

    //    public Task Invoke(HttpContext context)
    //    {
    //        LogContext.PushProperty("user_name", context.User.Identity.Name);

    //        return next(context);
    //    }
    //}
}
