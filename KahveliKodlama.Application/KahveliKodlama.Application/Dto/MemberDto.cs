using KahveliKodlama.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Dto
{
    public class MemberDto:IRequest<MemberDto>
    {
        public string Username { get; set; }

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