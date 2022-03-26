using System;

namespace KahveliKodlama.Application.Dto;

public class BaseDto
{
    public Guid Id { get; set; }

    public DateTime CreatedTime { get; set; }

    public int? ElapsedDay {

        get {
            return  (DateTime.UtcNow - CreatedTime).Days;
        }

       
    }

}
