using KahveliKodlama.Domain.Common;
using System.Collections.Generic;

namespace KahveliKodlama.Domain.Entities;

public class Category : BaseEntity
{

    //[Required(ErrorMessage = "Kategori alanı boş bırakılamaz..")]
    //[Display(Name = "Kategori Adı")]
    //[StringLength(30, ErrorMessage = "En fazla 20 karakter en az 3 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
    public string CategoryName { get; set; }
    public string CategoryDesc { get; set; }

    public string CategoryImage { get; set; }



    public bool CategoryActive { get; set; }


    public string CategoryCode { get; set; }
    public ICollection<Heading> Headings { get; set; }






}
