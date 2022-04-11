using AutoMapper;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KahveliKodlama.Application.Filters;

public class ValidationFilterAttribute : IActionFilter
{

    private readonly IMapper _mapper;


    public ValidationFilterAttribute(IMapper mapper)
    {

        _mapper = mapper;

    }


    public void OnActionExecuting(ActionExecutingContext context)
    {

        var param = context.ActionArguments.SingleOrDefault(v => v.Value is BaseDto).Value;

        if (param == null)
        {
            context.Result = new BadRequestObjectResult(new ResponseResult(Domain.Enum.ResponseCode.Not_Found, MessageHelper.validError));
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        return;
    }

}

