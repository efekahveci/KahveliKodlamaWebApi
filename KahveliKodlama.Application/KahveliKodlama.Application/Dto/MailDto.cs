using KahveliKodlama.Application.Attributes;

namespace KahveliKodlama.Application.Dto;
public class MailDto : BaseDto
{

    [Email]
    public string eMail { get; set; }

}
