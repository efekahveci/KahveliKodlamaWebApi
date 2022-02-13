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
        
        public int MemberId { get; set; }

       

    }
}
