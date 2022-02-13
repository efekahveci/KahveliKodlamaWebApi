using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Entities
{
    public class Response
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public IEnumerable<Response> Errors { get; set; }

        public Response(HttpStatusCode code)
        {
            Code = (int)code;
            Errors = new List<Response>();
        }
    }
}
