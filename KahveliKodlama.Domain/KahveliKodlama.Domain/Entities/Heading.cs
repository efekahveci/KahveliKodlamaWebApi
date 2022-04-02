using KahveliKodlama.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KahveliKodlama.Domain.Entities;

public class Heading : BaseEntity
{

    [StringLength(50)]
    public string HeadingName { get; set; }

    [StringLength(300)]
    public string HeadingContent { get; set; }
    [StringLength(200)]
    public string HeadingImage { get; set; }
    [StringLength(50)]
    public string HeadingTag { get; set; }
    public short HeadingViews { get; set; }

    [ForeignKey("MemberId")]
    public virtual Guid MemberId { get; set; }

    [ForeignKey("CategoryId")]
    public virtual Guid CategoryId { get; set; }

}
