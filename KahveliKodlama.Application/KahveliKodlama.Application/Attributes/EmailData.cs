using System;

namespace KahveliKodlama.Application.Attributes;

public enum EmailValidateType
{
    Syntax=1,
    Education=2,
    Government = 3,
    Gmail=4,
    Hotmail=5
}

[AttributeUsage(AttributeTargets.All)]
public class EmailData : Attribute
{
    public EmailData()
    {
    }
    public EmailValidateType type { get; set; }
}
