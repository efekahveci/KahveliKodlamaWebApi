﻿
using KahveliKodlama.Application.Security;
using System;
using System.Collections.Generic;
namespace KahveliKodlama.Application.Validators
{
    public record HashValidator<T>() : Validator, IValidator<T>
    {
        public List<Exception> Validate(T value, int? max, int? param2,string source, System.Reflection.PropertyInfo pi,object model)
        {
            var errorList = new List<Exception>();
            if (!typeof(T).IsValueType && typeof(T) != typeof(String))
            {
                throw new ArgumentException("T must be a value type or System.String.");
            }
            string stringValue = value.ToString();

            if (!IsEncryted(stringValue) && !IsHashed(stringValue))
            {
                // Hash to the Value
                using (Encryption en = new())
                {
                    pi.SetValue(model, "hasß"+en.HashCreate(stringValue, en.GenerateSalt()));
                }

                if (errorList.Count == 0) Console.WriteLine("All tests succesful");
            }
            return errorList;
        }
    }
}
