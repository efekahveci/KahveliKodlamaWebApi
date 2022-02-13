using KahveliKodlama.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Entities
{
    public class UpdateMember:BaseEntity
    {
       
    [StringLength(15, ErrorMessage = "En fazla 15 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
    [Display(Name = "İsim")]
    public string Name { get; set; }

    [StringLength(20, ErrorMessage = "En fazla 20 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
    [Display(Name = "Soyisim")]
    public string Surname { get; set; }

    [Display(Name = "Yaş")]

    public short? Age { get; set; }

    [StringLength(500)]

    [Display(Name = "Profil Fotoğrafı")]
    public string Image { get; set; }

    [Display(Name = "Hakkında")]
    [StringLength(500, ErrorMessage = "En fazla 500 karakter uzunluğunda olmalıdır.")]
    public string About { get; set; }

    [Display(Name = "Ünvan")]
    [StringLength(30, ErrorMessage = "En fazla 30 karakter uzunluğunda olmalıdır.")]
    public string Title { get; set; }
}
}
