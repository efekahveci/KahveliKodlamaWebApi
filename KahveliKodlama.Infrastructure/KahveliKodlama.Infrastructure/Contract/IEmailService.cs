using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;

namespace KahveliKodlama.Infrastructure.Contract;
public interface IEmailService
{

    Task<bool> SendPushEmail(Mail email);

    void EmailSendNotify(NewContentAdd content);
}
