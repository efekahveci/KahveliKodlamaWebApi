using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Infrastructure.Contract;
public interface IEmailService {

    Task<bool> SendPushEmail(Mail email);

    void EmailSendNotify(NewContentAdd content);
}
