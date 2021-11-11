using KahveliKodlama.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Entities
{
    public class Member : BaseEntity
    {
       
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
        public string UserName { get; set; }

        [Display(Name = "E-Posta Adresi")]
        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Geçersiz Email adres biçimi.")]
        [StringLength(30)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter en az 5 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [StringLength(15, ErrorMessage = "En fazla 15 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [StringLength(20, ErrorMessage = "En fazla 20 karakter en az 2 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
        [Display(Name = "Soyisim")]
        public string Surname { get; set; }

        [Display(Name = "Yaş")]
        [Range(18, 65, ErrorMessage = "Yaş 18'den küçük 65'ten büyük olamaz.")]
        public short? Age { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        [Display(Name = "Hakkında")]
        [StringLength(200, ErrorMessage = "En fazla 200 karakter uzunluğunda olmalıdır.")]
        public string About { get; set; }

        [Display(Name = "Ünvan")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter uzunluğunda olmalıdır.")]
        public string Title { get; set; }
        public bool? Authority { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
