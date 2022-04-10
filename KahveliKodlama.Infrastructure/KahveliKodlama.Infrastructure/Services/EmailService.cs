using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Infrastructure.Contract;
using KahveliKodlama.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;

namespace KahveliKodlama.Infrastructure.Services;
public class EmailService : IEmailService
{
    private readonly KahveliContext _context;
    public EmailService()
    {
        _context = EngineContext.Current.Resolve<KahveliContext>();
    }

    public DbSet<Mail> Table => _context.Set<Mail>();

    public void EmailSendNotify(NewContentAdd content)
    {

        foreach (var item in Table)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.To.Add(item.eMail);
                mail.From = new MailAddress("kahvelikodlama@gmail.com", "Şifre Güncelleme", System.Text.Encoding.UTF8);
                mail.Subject = "Şifre Güncelleme Talebi";
                mail.Body = content.Body;
                mail.IsBodyHtml = true;
                SmtpClient smp = new SmtpClient();
                smp.Credentials = new NetworkCredential("kahvelikodlama@gmail.com", "KahveKodla123");
                smp.Port = 587;
                smp.Host = "smtp.gmail.com";
                smp.EnableSsl = true;
                smp.Send(mail);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }

    public async Task<bool> SendPushEmail(Mail email)
    {

        var result = await Table.FirstOrDefaultAsync(x => x.eMail == email.eMail);

        if (result == null)
        {
            try
            {
                Mail mail = new Mail();

                mail.eMail = email.eMail;
                mail.CreatedTime = DateTime.UtcNow;
                mail.LastModifyTime = DateTime.UtcNow;

                await Table.AddAsync(mail);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }


        return false;


    }
}
