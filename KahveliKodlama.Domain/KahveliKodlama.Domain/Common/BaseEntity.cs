using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KahveliKodlama.Domain.Common;

public class BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public bool Status { get; set; } = true;
    public DateTime CreatedTime { get; set; } 
    public DateTime? LastModifyTime { get; set; }
    public DateTime? DeleteTime { get; set; }

    [StringLength(100)]
    public string Field1 { get; set; }
    [StringLength(200)]
    public string Field2 { get; set; }

}
