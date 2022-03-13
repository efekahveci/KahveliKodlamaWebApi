using System;
using System.Collections.Generic;
using System.Reflection;

namespace KahveliKodlama.Application.Validators
{
    public record DefaultValidator<T> : IValidator<T>
    {
        public List<Exception> Validate(T value,int? type, int? param2, string source,PropertyInfo pi,object model)
        {
            return new List<Exception>();
        }
    }
}
