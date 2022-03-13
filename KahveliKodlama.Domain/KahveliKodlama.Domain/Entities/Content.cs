using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KahveliKodlama.Domain.Entities
{
    public class Content : BaseEntity 
    {
      

        [Required(ErrorMessage = "Post alanı boş bırakılamaz..")]
        [Display(Name = "Post Adı")]
        [MinLength(3,ErrorMessage ="En az 3 kelime olmalı")]
        public string Post { get; set; }

        [ForeignKey("HeadingId")]
        public virtual Guid HeadingId { get; set; }
    }
}
