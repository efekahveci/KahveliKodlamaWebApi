using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Attributes;
public class Username:ValidationAttribute
{
   
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if(value == null)
            return new ValidationResult("Kullanıcı adını lütfen boş geçmeyiniz.");

        string text = value.ToString().Trim();

        if (!Regex.Match(text, @"^[a-zA-Z-']*$").Success)
            return new ValidationResult("Kullanıcı adında lütfen türkçe karakter kullanmayınız.");

        if (text.Length < 3)
            return new ValidationResult("Kullanıcı adınızı lütfen en az 4 karakter giriniz.");

        if (text.Length > 15)
            return new ValidationResult("Kullanıcı adınızı lütfen en fazla 15 karakter giriniz.");

       
        return ValidationResult.Success;

    }
}