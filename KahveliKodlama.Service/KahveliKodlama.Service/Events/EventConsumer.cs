using KahveliKodlama.Application.Contract;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.Contract;
using KahveliKodlama.Persistence.Context;


namespace KahveliKodlama.Service.Events;

public class EventConsumer : IConsumer<AppUser>
{
    private readonly KahveliContext _context;
    private readonly IEmailService _service;

    public EventConsumer(KahveliContext context,IEmailService service)
    {
        _service = service;
        _context = context;
    }

    public void HandleEventAsync(AppUser user)
    {
        var clone =  new Member { Password = user.Pass, UserName = user.UserName, Email = user.Email };

        _context.Set<Member>().Add(clone);
        _context.SaveChanges();

    }

    
}
