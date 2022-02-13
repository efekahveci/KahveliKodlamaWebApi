using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(25, ErrorMessage = "En fazla 25 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [StringLength(15, ErrorMessage = "En fazla 15 karakter en az 5 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]

        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
