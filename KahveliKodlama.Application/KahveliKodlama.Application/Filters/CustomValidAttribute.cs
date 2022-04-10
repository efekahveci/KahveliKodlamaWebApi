using System.ComponentModel.DataAnnotations;

namespace KahveliKodlama.Application.Filters;
public class CustomValidAttribute : ValidationAttribute
{

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value != null && value.ToString().Length > 0) return ValidationResult.Success;

        return new ValidationResult(ErrorMessage ?? $"{validationContext.DisplayName} boş olamaz");
    }

}
