
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Serilog;
using Serilog.Context;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    //private readonly ILoggerManager _logger;
    // private static readonly ILogger _logger = Log.ForContext<ExceptionMiddleware>();
    // private readonly ILogger Log = Serilog.Log.ForContext<ExceptionMiddleware>();

    public ExceptionMiddleware(RequestDelegate next)
    {
        // _logger = logger;
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        LogContext.PushProperty("path", Convert.ToString(httpContext.Request.Path));

        LogContext.PushProperty("user_name", Convert.ToString(httpContext.User.Identity.Name));
        LogContext.PushProperty("status", Convert.ToString(httpContext.Response.StatusCode));
        LogContext.PushProperty("method", Convert.ToString(httpContext.Request.Method));
        LogContext.PushProperty("request", Convert.ToString(await ReadBodyFromRequest(httpContext.Request)));
        //LogContext.PushProperty("response", Convert.ToString("ilk"));


        //var test =  Convert.ToString(await ReadBodyFromRequest(httpContext.Request));



        try
        {

            //var result = httpContext.Request.Method;

            //LogContext.PushProperty("user_name", httpContext.User.Identity.Name);

            //// var test = result.ToDictionary(x => x.Key, x => x.Value.ToString());

            //LogContext.PushProperty("path", Convert.ToString(httpContext.Request?.Path));

            //Log.ForContext("user_name", Convert.ToString(httpContext.Request.Method)).Warning($"Call efe getAll Method");


            //Log.Warning("Call" + Convert.ToString(httpContext.Request.Method));


            //LogContext.PushProperty("path", Convert.ToString(httpContext.Request.Path));

            //LogContext.PushProperty("user_name", Convert.ToString(httpContext.User.Identity.Name));
            //LogContext.PushProperty("status", Convert.ToString(httpContext.Response.StatusCode));
            //LogContext.PushProperty("method", Convert.ToString(httpContext.Request.Method));

     



            Log.Warning("_next");
          //  LogContext.PushProperty("response", Convert.ToString("kahveic"));


            await _next(httpContext);

            //LogContext.PushProperty("response", await new StreamReader(httpContext.Response.Body).ReadToEndAsync());






        }
        catch (Exception ex)
        {
            
            LogContext.PushProperty("ex", Convert.ToString(ex));
            Log.Warning("_error");

            //  _logger.LogError($"Something went wrong: {ex}");
            //var now = DateTime.UtcNow;
            //Log.Error("");
            //LogContext.PushProperty("midex", $"{now.ToString("HH:mm:ss")} : {ex}");
            //LogContext.PushProperty("midex", "test");

            await HandleExceptionAsync(httpContext, ex);
            //LogContext.PushProperty("midex", "test");
            //Log.ForContext("midex", "exception").Warning($"Call efe getAll Method");

        }

     


    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        // _logger.Error($"{DateTime.Now.ToString("HH:mm:ss")} : {exception}");
        await context.Response.WriteAsync(new ResponseResult(Domain.Enum.ResponseCode.Internal_Server_Error, exception.ToString()).ToString());
    }


    private static async Task<string> ReadBodyFromRequest(HttpRequest request)
    {
        // Ensure the request's body can be read multiple times (for the next middlewares in the pipeline).
        request.EnableBuffering();

        using var streamReader = new StreamReader(request.Body, leaveOpen: true);
        var requestBody = await streamReader.ReadToEndAsync();

        // Reset the request's body stream position for next middleware in the pipeline.
        request.Body.Position = 0;
        return requestBody;
    }

 
 
}
