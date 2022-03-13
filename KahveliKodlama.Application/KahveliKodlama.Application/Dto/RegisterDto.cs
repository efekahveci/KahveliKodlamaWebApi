namespace KahveliKodlama.Application.Dto
{
    public class RegisterDto : BaseDto
    {
        //[Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        //[Display(Name = "Kullanıcı Adı")]
        //[StringLength(25, ErrorMessage = "En fazla 25 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
        public string Username { get; set; }

        //[Display(Name = "E-Posta Adresi")]
        //[Required(ErrorMessage = "Email alanı gereklidir.")]
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "Geçersiz Email adres biçimi.")]
        //[StringLength(50)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Şifre alanı gereklidir.")]
        //[StringLength(15, ErrorMessage = "En fazla 15 karakter en az 5 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]

        //[Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
