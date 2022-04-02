using KahveliKodlama.Application.Attributes;
using System;

namespace KahveliKodlama.Application.Dto;

public class HeadingDto : BaseDto
{
    public Guid CategoryId { get; set; }

    public Guid MemberId { get; set; }

    [StringLength(50)]

    public string HeadingName { get; set; }
    [StringLength(200)]

    public string HeadingImage { get; set; }

    [StringLength(300)]

    public string HeadingContent { get; set; }

    [StringLength(50)]

    public string HeadingTag { get; set; }


}
