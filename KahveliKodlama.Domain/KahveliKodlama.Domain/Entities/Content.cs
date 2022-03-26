using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KahveliKodlama.Domain.Entities;

public class Content : BaseEntity 
{
  

    [Required(ErrorMessage = "Post alanı boş bırakılamaz..")]
    [Display(Name = "Post Adı")]
    [MinLength(3,ErrorMessage ="En az 3 kelime olmalı")]
    public string Post1 { get; set; }
    public string PostH1 { get; set; }
    public string Post2 { get; set; }
    public string PostCode { get; set; }


    [ForeignKey("HeadingId")]
    public virtual Guid HeadingId { get; set; }
}
