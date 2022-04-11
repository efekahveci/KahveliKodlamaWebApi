using KahveliKodlama.Application.Filters;
using KahveliKodlama.Domain.Entities;
using System.Collections.Generic;

namespace KahveliKodlama.Application.Dto;

public class MemberDto : BaseDto
{
    public string Username { get; set; }

    [CustomValid]
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public string About { get; set; }
    public string Title { get; set; }
    public string Point { get; set; }

    public ICollection<Heading> Headings { get; set; }
}
