using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Auth
{
    public class ResetPassViewModel
    {
        [Display(Name = "E-Posta Adresiniz")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi boş geçmeyiniz.")]
        [EmailAddress(ErrorMessage = "Lütfen uygun formatta e-posta giriniz.")]
        public string Email { get; set; }
    }
}
