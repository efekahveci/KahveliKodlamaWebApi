using System.ComponentModel.DataAnnotations;

namespace KahveliKodlama.Domain.Auth;

public class UpdatePassViewModel
{
    [Display(Name = "Yeni Şifre")]
    [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
