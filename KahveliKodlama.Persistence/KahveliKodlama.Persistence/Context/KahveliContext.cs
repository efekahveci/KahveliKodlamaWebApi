using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.Context
{
    public class KahveliContext : DbContext
    {
        public KahveliContext(DbContextOptions<KahveliContext> options) : base(options)
        {
        }
 
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Image).HasDefaultValue("Empty");
                entity.Property(e => e.Age).HasDefaultValue(Convert.ToInt16(1));
                entity.Property(e => e.About).HasDefaultValue("Empty");
                entity.Property(e => e.Title).HasDefaultValue("Empty");
                entity.Property(e => e.Authority).HasDefaultValue(false);
                entity.Property(e => e.Status).HasDefaultValue(false);
                entity.Property(e => e.CreatedTime).HasDefaultValueSql("getdate()");
                entity.Property(e => e.LastModifyTime).HasDefaultValueSql("getdate()");

            });

            modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 1,
                UserName = "efekhvci",
                Email = "efekhvci@hotmail.com",
                Password = "12345",
                Name = "Mehmet Efe",
                Surname = "Kahveci",
                Age = 23,
                About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliği",
                Title = "Developer",
                Authority = true,
                Status = true,
            });
            modelBuilder.Entity<Heading>().HasData(new Heading
            {
                Id = 1,
                CategoryId = 1,
                 HeadingName= ".NET CORE",
                HeadingContent = "WEB AP",
                 HeadingViews= 99,
                MemberId = 1,
                HeadingTag = "Kahveci",
         
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id=1,
                CategoryName="Nesneye Yönelimli Programalama",
                   

            });
            ;
            base.OnModelCreating(modelBuilder);

        }
        
    }
}
