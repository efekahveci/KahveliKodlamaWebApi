using KahveliKodlama.Service.Middleware;
using Microsoft.AspNetCore.Builder;

namespace KahveliKodlama.Service.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
