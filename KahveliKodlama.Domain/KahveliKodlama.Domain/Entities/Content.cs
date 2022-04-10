using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace KahveliKodlama.Domain.Entities;

public class Content : BaseEntity
{


    public string ContentImage1url { get; set; }
    public string Content1 { get; set; }
    public string ContentHeading2 { get; set; }
    public string Content2 { get; set; }

    public string CodeBlock1 { get; set; }
    public string ContentHeading3 { get; set; }
    public string Content3 { get; set; }


    [ForeignKey("HeadingId")]
    public virtual Guid HeadingId { get; set; }

}
