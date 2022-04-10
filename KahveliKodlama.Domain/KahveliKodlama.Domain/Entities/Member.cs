using KahveliKodlama.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KahveliKodlama.Domain.Entities;

public class Member : BaseEntity
{

    //[Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
    //[Display(Name = "Kullanıcı Adı")]
    //[StringLength(25, ErrorMessage = "En fazla 25 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
    public string UserName { get; set; }

    //[Display(Name = "E-Posta Adresi")]
    //[Required(ErrorMessage = "Email alanı gereklidir.")]
    //[DataType(DataType.EmailAddress)]
    //[EmailAddress(ErrorMessage = "Geçersiz Email adres biçimi.")]
    //[StringLength(50)]
    public string Email { get; set; }


    [Display(Name = "Cinsiyet")]
    public bool Gender { get; set; }

    //[Required(ErrorMessage = "Şifre alanı gereklidir.")]
    //[StringLength(15, ErrorMessage = "En fazla 15 karakter en az 5 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]

    //[StringLength(15, ErrorMessage = "En fazla 15 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
    //[Display(Name = "İsim")]
    public string Name { get; set; }

    //[StringLength(20, ErrorMessage = "En fazla 20 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
    //[Display(Name = "Soyisim")]
    public string Surname { get; set; }

    [Display(Name = "Yaş")]

    public short? Age { get; set; }

    [StringLength(500)]

    //[Display(Name = "Profil Fotoğrafı")]
    public string Image { get; set; }

    [Display(Name = "Hakkında")]
    //[StringLength(500, ErrorMessage = "En fazla 500 karakter uzunluğunda olmalıdır.")]
    public string About { get; set; }

    [Display(Name = "Ünvan")]
    //[StringLength(30, ErrorMessage = "En fazla 30 karakter uzunluğunda olmalıdır.")]
    public string Title { get; set; }
    public bool? Authority { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public int Point { get; set; }

    public bool IsVerifiedEmail { get; set; }
    public bool IsVerifiedInfo { get; set; }
    public ICollection<Heading> Headings { get; set; }

}
