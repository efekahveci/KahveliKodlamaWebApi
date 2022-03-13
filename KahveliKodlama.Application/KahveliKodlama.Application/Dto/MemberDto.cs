using KahveliKodlama.Application.Attributes;
using KahveliKodlama.Domain.Entities;
using MediatR;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KahveliKodlama.Application.Dto
{
    //[ModelBinder(typeof(DefaultModelBinder<MemberDto>))]
    public class MemberDto : BaseDto, IRequest<MemberDto>
    {
        public string Username { get; set; }
        [StringData(max = 10, min = 3)]
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string About { get; set; }
        public string Title { get; set; }
        public string Point { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}