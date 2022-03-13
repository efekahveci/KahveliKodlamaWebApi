using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace KahveliKodlama.Application.Validators
{
    public static class ValidateClassProperties
    {

        public static List<Exception> GetValidatoResult(object model)
        {
            var errorList = new List<Exception>();
         
            PropertyInfo[] properties =
            model.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                for (int i = 0; i < property.GetCustomAttributes(true).Length; i++) //It could be more than one Attribute.
                {                
                    Type type = property.GetCustomAttributes(true)[i].GetType();
                    var validator = ValidatorFactory<string>.GetValidator(type);

                    string propValue = property.GetValue(model).ToString();
                    int? attributeValue = null;
                    int? attributeValue2 = null;
                    if (property.GetCustomAttributesData()[i].NamedArguments.Count > 0) //Has Parameter on "Attribute" 
                    {
                        attributeValue = (int)property.GetCustomAttributesData()[i].NamedArguments[0].TypedValue.Value;
                        if (property.GetCustomAttributesData()[i].NamedArguments.Count > 1)
                        {
                            attributeValue2 = (int)property.GetCustomAttributesData()[i].NamedArguments[1].TypedValue.Value;
                        }
                    }
              
                    foreach (Exception err in validator.Validate(propValue, attributeValue, attributeValue2, property.Name, property, model))
                    {
                    
                        errorList.Add(err);
                    }
                 
                    //}
                }               
            }       
            return errorList;
        }
    }
}
