using System;
using System.Collections.Generic;
using System.Reflection;

namespace KahveliKodlama.Application.Validators;

public interface IValidator<T>
{
    List<Exception> Validate(T value, int? param, int? param2, string source, PropertyInfo pi, object model);
}   
