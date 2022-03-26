using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Attributes;
public class Email : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
            return new ValidationResult("Email'i lütfen boş geçmeyiniz.");

        string text = value.ToString().Trim();

        if (!Regex.Match(text,@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            return new ValidationResult("Email'i geçerli giriniz");

        if (text.Length > 30)
            return new ValidationResult("Email'i lütfen en fazla 30 karakter giriniz.");

        return ValidationResult.Success;
    }

}