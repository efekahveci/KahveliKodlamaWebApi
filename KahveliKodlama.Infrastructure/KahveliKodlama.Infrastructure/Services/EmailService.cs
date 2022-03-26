using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Infrastructure.Contract;
using KahveliKodlama.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Infrastructure.Services;
public class EmailService : IEmailService
{
    private readonly KahveliContext _context;
    public EmailService()
    {
        _context = EngineContext.Current.Resolve<KahveliContext>();
    }

    public DbSet<Mail> Table => _context.Set<Mail>();


    public async Task<bool> SendPushEmail(Mail email)
    {

        try
        {
            Mail mail = new Mail();

            mail.eMail = email.eMail;

            await Table.AddAsync(mail);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception )
        {
            return false;

        }
     

      
    }
}
