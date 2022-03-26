using MediatR;

namespace KahveliKodlama.Application.Dto;

public class MernisDto : BaseDto
{


    public string TCKNO { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public int Year { get; set; }

}
