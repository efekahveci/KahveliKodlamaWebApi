using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Dto
{
    public class ExceptionDto : BaseDto
    {


        public string Source { get; set; }
        public string Message { get; set; }
    }
}
