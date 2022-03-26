using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace KahveliKodlama.Persistence.ObjectBuilder.Members;

public partial class MemberBuilder : EntityBuilder<Member>
{
    public override void MapEntity(ModelBuilder builder)
    {
        builder.Entity<Member>(entity =>
        {
           //Eklenecek kayıtlarda varsayılan değerler atama
            entity.Property(e => e.Image).HasDefaultValue("Empty");
            entity.Property(e => e.Age).HasDefaultValue(Convert.ToInt16(1));
            entity.Property(e => e.About).HasDefaultValue("Empty");
            entity.Property(e => e.Title).HasDefaultValue("Empty");
            entity.Property(e => e.Authority).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.CreatedTime).HasDefaultValueSql("now()");
            entity.Property(e => e.LastModifyTime).HasDefaultValueSql("now()");

        });

        //builder.Entity<Member>().HasData(new Member
        //{
        //    Id = Guid.Parse("4ebf1452-3bdc-1618-a25a-c31575c89074"),
        //    UserName = "efekahveci",
        //    Email = "efekhvci@hotmail.com",
        //    Password = "12345efe",
        //    Name = "Mehmet Efe",
        //    Surname = "Kahveci",
        //    Age = 23,
        //    About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak t-soft e ticaret sistemleri bünyesinde çalışmaktayım. Net core ve " +
        //    "angular üzerinde kendimi geliştiriyorum az düzeyde ingilizce biliyorum",
        //    Title = "Software Engineer",
        //    Authority = true,
        //    Status = true,
        //    IsVerifiedEmail = true,
        //    CreatedTime = DateTime.UtcNow,
        //    LastModifyTime = DateTime.UtcNow,
        //    Dislike =14,
        //    Gender =true,
        //    Image ="Resim Yok",
        //    Like=8,
        //    IsVerifiedInfo = true,
        //    Point = 98
            
        //});

        //builder.Entity<Member>().HasData(new Member
        //{
        //    Id = Guid.Parse("4ebf1452-3bdc-2618-a25a-c31575c89074"),
        //    UserName = "yusufcakmak",
        //    Email = "ysfckmk@hotmail.com",
        //    Password = "12345yusuf",
        //    Name = "Yusuf",
        //    Surname = "Çakmak",
        //    Age = 24,
        //    About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında react js beckend tarafında ise" +
        //    ".net ile çalışmalar yapıyorum.",
        //    Title = "Student",
        //    Authority = true,
        //    Status = true,
        //    IsVerifiedEmail = true,
        //    CreatedTime = DateTime.UtcNow,
        //    LastModifyTime = DateTime.UtcNow,
        //    Dislike = 1,
        //    Gender = true,
        //    Image = "Resim Yok",
        //    Like = 6,
        //    IsVerifiedInfo = true,
        //    Point = 657
        //});
        //builder.Entity<Member>().HasData(new Member
        //{
        //    Id = Guid.Parse("4ebf1452-3bdc-3618-a25a-c31575c89074"),
        //    UserName = "akmansoy",
        //    Email = "remzican@hotmail.com",
        //    Password = "12345remzi",
        //    Name = "Remzi Can",
        //    Surname = "Akmansoy",
        //    Age = 24,
        //    About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında angular js beckend tarafında ise" +
        //    ".net ile çalışmalar yapıyorum. Ayrıca yurtdışında çalışmak ilk tercihim olacaktır.",
        //    Title = "Student",
        //    Authority = true,
        //    Status = true,
        //    IsVerifiedEmail = true,
        //    CreatedTime = DateTime.UtcNow,
        //    LastModifyTime = DateTime.UtcNow,
        //    Dislike = 13,
        //    Gender = true,
        //    Image = "Resim Yok",
        //    Like = 65,
        //    IsVerifiedInfo = true,
        //    Point = 12
        //});

      


    }
}
