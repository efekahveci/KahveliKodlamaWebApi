using AutoMapper;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Application.Validators;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Common;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Filters;

public class ValidationFilterAttribute :IActionFilter
{

    private readonly IMapper _mapper;


    public ValidationFilterAttribute(IMapper mapper)
    {

        _mapper = mapper;

    }

    //protected override ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext)
    //{
    //    if (value!=null)
    //    {
    //        return ValidationResult.Success;
    //    }

    //    return new ValidationResult("hata mesajı");
    //}
  
    public void OnActionExecuting(ActionExecutingContext context)
    {

        var param = context.ActionArguments.SingleOrDefault(v => v.Value is BaseDto).Value;

        var valid = ValidateClassProperties.GetValidatoResult(param);

        if (valid.Count != 0)
        {
            context.Result = new BadRequestObjectResult(new ResponseResult(Domain.Enum.ResponseCode.Not_Found, MessageHelper.validError, _mapper.Map<List<Exception>, List<ExceptionDto>>(valid)));
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        return;
    }
    //        public void OnActionExecuted(ActionExecutedContext actionExecutedContext)
    //        {
    //            if (actionExecutedContext.Exception != null && !actionExecutedContext.ExceptionHandled)
    //            {
    //              //  Serilog.Log.Logger.Error(actionExecutedContext.Exception, actionExecutedContext.Exception?.Message);



    //                var error = new KeyValuePair<string, List<string>>("internal_server_error",
    //                new List<string>
    //                {
    //actionExecutedContext.Exception?.Message
    //                    //"please, contact the owner"
    //                });
    //                actionExecutedContext.Exception = null;
    //                actionExecutedContext.ExceptionHandled = true;
    //                SetError(actionExecutedContext, error);
    //            }
    //            else if (actionExecutedContext.HttpContext.Response != null &&
    //            (HttpStatusCode)actionExecutedContext.HttpContext.Response.StatusCode != HttpStatusCode.OK)
    //            {
    //                string responseBody;



    //                using (var streamReader = new StreamReader(actionExecutedContext.HttpContext.Response.Body))
    //                {
    //                    responseBody = streamReader.ReadToEnd();
    //                }



    //                // reset reader position.
    //                actionExecutedContext.HttpContext.Response.Body.Position = 0;



    //                var defaultWebApiErrorsModel = System.Text.Json.JsonSerializer.Deserialize<ResponseResult>(responseBody);



    //                // If both are null this means that it is not the default web api error format,
    //                // which means that it the error is formatted by our standard and we don't need to do anything.
    //                if (!string.IsNullOrEmpty(defaultWebApiErrorsModel.Message))
    //                {
    //                    var error = new KeyValuePair<string, List<string>>("lookup_error", new List<string>
    //                    {
    //                    "not found"
    //                    });
    //                    SetError(actionExecutedContext, error);
    //                }
    //            }

    //        }



    //        private void SetError(ActionExecutedContext actionExecutedContext, KeyValuePair<string, List<string>> error)
    //        {
    //            var bindingError = new Dictionary<string, List<string>>
    //{
    //{
    //error.Key, error.Value
    //}
    //};



    //            var errorJson ="{'hata':'efenin'}";
    //            var response = new ContentResult();
    //            response.Content = errorJson;
    //            response.ContentType = "application/json";
    //            response.StatusCode = (int)HttpStatusCode.InternalServerError;
    //            actionExecutedContext.Result = response;



    //        }

}

