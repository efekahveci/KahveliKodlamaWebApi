using KahveliKodlama.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Entities
{
    public class ResponseResult
    {
        public ResponseResult(ResponseCode responseCode, string message)
        {
            StatusCode = responseCode;
            Message = message;

        }



        public ResponseResult(ResponseCode responseCode, string message, object data) : this(responseCode, message)
        {

            Data = data;

        }

       


        public ResponseCode StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
