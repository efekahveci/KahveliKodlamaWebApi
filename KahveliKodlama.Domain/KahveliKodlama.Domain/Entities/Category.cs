using KahveliKodlama.Domain.Common;
using System.Collections.Generic;

namespace KahveliKodlama.Domain.Entities;

public class Category : BaseEntity
{

    public string CategoryName { get; set; }
    public string CategoryDesc { get; set; }

    public string CategoryImage { get; set; }



    public bool CategoryActive { get; set; }


    public string CategoryCode { get; set; }
    public ICollection<Heading> Headings { get; set; }






}
