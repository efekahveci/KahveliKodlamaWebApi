using KahveliKodlama.Application.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Dto;
public class MailDto:BaseDto {

    [Email]
    public string eMail { get; set; }

}
