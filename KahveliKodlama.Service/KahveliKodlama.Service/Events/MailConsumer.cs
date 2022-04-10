using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Infrastructure.Contract;

namespace KahveliKodlama.Service.Events;
public class MailConsumer : IConsumer<NewContentAdd>
{
    private readonly IEmailService _service;
    public MailConsumer(IEmailService service)
    {
        _service = service;
    }

    public void HandleEventAsync(NewContentAdd eventMessage)
    {
        _service.EmailSendNotify(eventMessage);
    }
}
