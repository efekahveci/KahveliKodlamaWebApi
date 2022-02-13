using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.ObjectBuilder.Headings
{
    public class HeadingBuilder : EntityBuilder<Heading>
    {
        public override void MapEntity(ModelBuilder builder)
        {
            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 1,
                CategoryId = 1,
                HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                HeadingViews = 45,
                MemberId = 1,
                HeadingTag = "Visual Studio",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true
            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 2,
                CategoryId = 2,
                HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                HeadingViews = 98,
                MemberId = 1,
                HeadingTag = "Angular",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 3,
                CategoryId = 3,
                HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                HeadingViews = 90,
                MemberId = 1,
                HeadingTag = "c#",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 4,
                CategoryId = 1,
                HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                HeadingViews = 45,
                MemberId = 2,
                HeadingTag = "Visual Studio",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true
            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 5,
                CategoryId = 2,
                HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                HeadingViews = 98,
                MemberId = 2,
                HeadingTag = "Angular",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 6,
                CategoryId = 3,
                HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                HeadingViews = 90,
                MemberId = 2,
                HeadingTag = "c#",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 7,
                CategoryId = 1,
                HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                HeadingViews = 45,
                MemberId = 3,
                HeadingTag = "Visual Studio",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true
            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 8,
                CategoryId = 2,
                HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                HeadingViews = 98,
                MemberId = 3,
                HeadingTag = "Angular",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });

            builder.Entity<Heading>().HasData(new Heading
            {
                Id = 9,
                CategoryId = 3,
                HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                HeadingViews = 90,
                MemberId = 3,
                HeadingTag = "c#",
                ContentId = 1,
                CreatedTime = DateTime.UtcNow,
                LastModifyTime = DateTime.UtcNow,
                Status = true

            });
        }
    }
}