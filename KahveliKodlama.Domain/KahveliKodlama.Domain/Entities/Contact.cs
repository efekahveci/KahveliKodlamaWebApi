using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
namespace KahveliKodlama.Domain.Entities;

public class Contact : BaseEntity
{

    [Required(ErrorMessage = "Başlık alanı boş bırakılamaz..")]
    [Display(Name = "Başlık Adı")]
    [StringLength(30, ErrorMessage = "En fazla 30 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
    public string Title { get; set; }

    [Required(ErrorMessage = "İçerik alanı boş bırakılamaz..")]
    [Display(Name = "İçerik Bilgisi")]
    [StringLength(1000, ErrorMessage = "En fazla 1000 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
    public string Content { get; set; }
    
    public Guid MemberId { get; set; }

   

}
