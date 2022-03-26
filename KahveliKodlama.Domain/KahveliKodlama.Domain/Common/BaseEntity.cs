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


    public string Field0 { get; set; }
    public string Field1 { get; set; }
    public string Field2 { get; set; }

}
