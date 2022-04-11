using KahveliKodlama.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KahveliKodlama.Domain.Entities;

public class Member : BaseEntity
{

    public string UserName { get; set; }


    public string Email { get; set; }


    [Display(Name = "Cinsiyet")]
    public bool Gender { get; set; }


    public string Name { get; set; }


    public string Surname { get; set; }

    [Display(Name = "Yaş")]

    public short? Age { get; set; }

    [StringLength(500)]

    public string Image { get; set; }

    [Display(Name = "Hakkında")]
    public string About { get; set; }

    [Display(Name = "Ünvan")]
    public string Title { get; set; }
    public bool? Authority { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public int Point { get; set; }

    public bool IsVerifiedEmail { get; set; }
    public bool IsVerifiedInfo { get; set; }
    public ICollection<Heading> Headings { get; set; }

}
