
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

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        LogContext.PushProperty("path", Convert.ToString(httpContext.Request.Path));

        LogContext.PushProperty("user_name", Convert.ToString(httpContext.User.Identity.Name));
        LogContext.PushProperty("status", Convert.ToString(httpContext.Response.StatusCode));
        LogContext.PushProperty("method", Convert.ToString(httpContext.Request.Method));
        LogContext.PushProperty("request", Convert.ToString(await ReadBodyFromRequest(httpContext.Request)));


        try
        {

            Log.Warning("_next");

            await _next(httpContext);


        }
        catch (Exception ex)
        {

            LogContext.PushProperty("ex", Convert.ToString(ex));

            await HandleExceptionAsync(httpContext, ex);

        }


    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        await context.Response.WriteAsync(new ResponseResult(Domain.Enum.ResponseCode.Internal_Server_Error, exception.ToString()).ToString());
    }


    private static async Task<string> ReadBodyFromRequest(HttpRequest request)
    {
        request.EnableBuffering();

        using var streamReader = new StreamReader(request.Body, leaveOpen: true);
        var requestBody = await streamReader.ReadToEndAsync();
        request.Body.Position = 0;
        return requestBody;
    }



}
