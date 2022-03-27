using KahveliKodlama.Application.Attributes;
using System;

namespace KahveliKodlama.Application.Dto;

public class HeadingDto : BaseDto
{
    public Guid CategoryId { get; set; }

    public Guid  MemberId { get; set; }
    [StringLength(30)]

    public string HeadingName    { get; set; }
   
    public string HeadingImage { get; set; }

    [StringLength(250)]
    public string HeadingContent  { get; set; }
   

    public string HeadingTag      { get; set; }

    
}
