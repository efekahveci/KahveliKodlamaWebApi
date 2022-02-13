using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Dto
{
    public class MernisDto : IRequest<MernisDto>
    {


        public string TCKNO { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
 
    }
}