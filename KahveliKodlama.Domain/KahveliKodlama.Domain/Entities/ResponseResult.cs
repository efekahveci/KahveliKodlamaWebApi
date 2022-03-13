using KahveliKodlama.Domain.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

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
           
            Records = ((IEnumerable<object>)data).Count();
    
        }




        public ResponseCode StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int Records { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
