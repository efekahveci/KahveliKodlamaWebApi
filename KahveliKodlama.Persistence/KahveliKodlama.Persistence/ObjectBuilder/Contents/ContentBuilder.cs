using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.ObjectBuilder.Contents
{
    public class ContentBuilder : EntityBuilder<Content>
    {
        public override void MapEntity(ModelBuilder builder)
        {
          

            builder.Entity<Content>().HasData(new Content
            {
                Id = 1,
                Post="Ef Coreda İlişki kuramıyorum",
                HeadingId=1
                

            });
        
        }
    }
}
