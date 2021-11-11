﻿using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.Context;
using KahveliKodlama.Persistence.Repositories;
using KahveliKodlama.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation
{
    public class ContactService : AsyncGenericRepository<Contact>,IContactService
    {
     
    }
}