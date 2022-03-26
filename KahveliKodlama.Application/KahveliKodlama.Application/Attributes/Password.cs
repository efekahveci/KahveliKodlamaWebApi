using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Attributes;
public class Password : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
{
    if (value == null)
        return new ValidationResult("Şifreyi lütfen boş geçmeyiniz.");

    string text = value.ToString().Trim();

    if (text.Length < 5)
        return new ValidationResult("Şifreyi lütfen en az karakter 5 giriniz.");

    if (text.Length > 15)
        return new ValidationResult("Şifreyi lütfen en fazla 15 karakter giriniz.");

    return ValidationResult.Success;
}

}
