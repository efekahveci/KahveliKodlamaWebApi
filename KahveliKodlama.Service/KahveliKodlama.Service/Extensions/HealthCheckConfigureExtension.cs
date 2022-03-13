using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace KahveliKodlama.WebApi.Extensions
{
    public static class HealthCheckConfigureExtension
    {
        public static IApplicationBuilder UseCustomHealthCheck(this IApplicationBuilder app)
        {
            app.UseHealthChecks("/api/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions()
            {
                ResponseWriter = async (context, report) =>
                {
                    await context.Response.WriteAsync("OK");
                }
            });

            return app;
        }
    }
}
