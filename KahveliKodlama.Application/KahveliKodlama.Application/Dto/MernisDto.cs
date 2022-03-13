using MediatR;

namespace KahveliKodlama.Application.Dto
{
    public class MernisDto : BaseDto, IRequest<MernisDto>
    {


        public string TCKNO { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
 
    }
}