using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KahveliKodlama.Domain.Entities;

public class Heading : BaseEntity
{

    //[Required(ErrorMessage = "Başlık alanı gereklidir.")]
    //[StringLength(20, ErrorMessage = "En fazla 20 karakter en az 5 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]

    [Display(Name = "Başlık Adı")]
    public string HeadingName { get; set; }

    //[StringLength(500, ErrorMessage = "En fazla 500 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
    //[Display(Name = "Başlık Açıklaması")]
    public string HeadingContent { get; set; }
    public string HeadingImage { get; set; }


    [Display(Name ="Etiket")]
    public string HeadingTag { get; set; }



    [Display(Name = "Görüntüleme")]
    public int HeadingViews { get; set; }


    [ForeignKey("MemberId")]
    public virtual Guid MemberId { get; set; }

    [ForeignKey("CategoryId")]
    public virtual Guid CategoryId { get; set; }

   
}
