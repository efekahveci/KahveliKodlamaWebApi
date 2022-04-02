using System;

namespace KahveliKodlama.Application.Dto;

public class ContentDto : BaseDto
{
   
    public string ContentImage1url { get; set; }
    public string Content1 { get; set; }
    public string ContentHeading2 { get; set; }
    public string Content2 { get; set; }
    public string CodeBlock1 { get; set; }
    public string ContentHeading3 { get; set; }
    public string Content3 { get; set; }

    public virtual Guid HeadingId { get; set; }

}
