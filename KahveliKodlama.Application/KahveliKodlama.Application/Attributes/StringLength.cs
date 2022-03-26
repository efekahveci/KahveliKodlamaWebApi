using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Attributes;
public class StringLength: ValidationAttribute
{
    readonly int _length;

    public StringLength(int lenght)
    {
        _length = lenght;   
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
            return new ValidationResult($"{validationContext.DisplayName}'i lütfen boş geçmeyiniz.");

        string text = value.ToString().Trim();

        if (text.Length > _length)
            return new ValidationResult($"{validationContext.DisplayName}'i lütfen en fazla {_length} karakter giriniz.");

        return ValidationResult.Success;
    }
}
