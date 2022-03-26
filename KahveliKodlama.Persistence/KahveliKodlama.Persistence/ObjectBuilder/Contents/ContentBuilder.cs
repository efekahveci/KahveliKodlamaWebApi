using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace KahveliKodlama.Persistence.ObjectBuilder.Contents;

public class ContentBuilder : EntityBuilder<Content>
{
    public override void MapEntity(ModelBuilder builder)
    {
      

        //builder.Entity<Content>().HasData(new Content
        //{
        //    Id = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
        //    Post ="Ef Coreda İlişki kuramıyorum",
        //    HeadingId= Guid.Parse("4ebf1452-3bdc-4618-a25a-c31575c89074"),


        //});
    
    }
}
