using System;

namespace KahveliKodlama.Application.Dto;

public class ContactDto : BaseDto
{
   
    public string Post1 { get; set; }
    public string PostH1 { get; set; }
    public string Post2 { get; set; }
    public string PostCode { get; set; }


    public virtual Guid HeadingId { get; set; }
}
