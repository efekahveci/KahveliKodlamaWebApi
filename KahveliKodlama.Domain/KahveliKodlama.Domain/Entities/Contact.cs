using KahveliKodlama.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KahveliKodlama.Domain.Entities
{
    public class Contact : BaseEntity
    {
       
        public string Title { get; set; }
        public string Content { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
       

    }
}
