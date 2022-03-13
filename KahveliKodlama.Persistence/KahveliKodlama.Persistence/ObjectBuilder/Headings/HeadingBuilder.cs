using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace KahveliKodlama.Persistence.ObjectBuilder.Headings
{
    public class HeadingBuilder : EntityBuilder<Heading>
    {
        public override void MapEntity(ModelBuilder builder)
        {
            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("4ebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId =  Guid.Parse("1ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                HeadingViews = 45,
                MemberId = Guid.Parse("4ebf1452-3bdc-3618-a25a-c31575c89074"),
                HeadingTag = "Visual Studio",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true
            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("5ebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("2ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                HeadingViews = 98,
                MemberId = Guid.Parse("4ebf1452-3bdc-3618-a25a-c31575c89074"),
                HeadingTag = "Angular",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("6ebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("3ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                HeadingViews = 90,
                MemberId = Guid.Parse("4ebf1452-3bdc-3618-a25a-c31575c89074"),
                HeadingTag = "c#",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("7ebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("1ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                HeadingViews = 45,
                MemberId = Guid.Parse("4ebf1452-3bdc-1618-a25a-c31575c89074"),
                HeadingTag = "Visual Studio",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true
            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("8ebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("2ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                HeadingViews = 98,
                MemberId = Guid.Parse("4ebf1452-3bdc-1618-a25a-c31575c89074"),
                HeadingTag = "Angular",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("9ebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("3ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                HeadingViews = 90,
                MemberId = Guid.Parse("4ebf1452-3bdc-1618-a25a-c31575c89074"),
                HeadingTag = "c#",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("aebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("1ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                HeadingViews = 45,
                MemberId = Guid.Parse("4ebf1452-3bdc-2618-a25a-c31575c89074"),
                HeadingTag = "Visual Studio",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true
            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("bebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("2ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                HeadingViews = 98,
                MemberId = Guid.Parse("4ebf1452-3bdc-2618-a25a-c31575c89074"),
                HeadingTag = "Angular",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = Guid.Parse("cebf1452-3bdc-4618-a25a-c31575c89074"),
                CategoryId = Guid.Parse("3ebf1452-3bdc-4618-a25a-c31575c89074"),
                HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                HeadingViews = 90,
                MemberId = Guid.Parse("4ebf1452-3bdc-2618-a25a-c31575c89074"),
                HeadingTag = "c#",
                ContentId = Guid.Parse("4ebf1452-3bdc-2618-225a-c31575c89074"),
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });
        }
    }
}