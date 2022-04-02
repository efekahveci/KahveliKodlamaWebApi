using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
namespace KahveliKodlama.Domain.Entities;

public class Contact : BaseEntity
{

    public string Title { get; set; }
    public string Content { get; set; }
    
    public string Email { get; set; }

   

}
