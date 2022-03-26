using EntityFrameworkCore.Triggered;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Persistence.Context;
using System.Threading;
using System.Threading.Tasks;


namespace KahveliKodlama.Persistence.Triggers;

//Kapatıldı açmak için database trigger eklenemesi gerekiyor
public class CloneUser : IBeforeSaveTrigger<AppUser>
{
    private readonly KahveliContext _context;
    public CloneUser()
    {
        _context = EngineContext.Current.Resolve<KahveliContext>();
    }

    public Task BeforeSave(ITriggerContext<AppUser> context, CancellationToken cancellationToken)
    {
        var clone = new Member { Password = context.Entity.Pass, UserName = context.Entity.UserName, Email = context.Entity.Email};

        _context.Set<Member>().Add(clone);
        _context.SaveChanges();


        return Task.CompletedTask;
    }
}
