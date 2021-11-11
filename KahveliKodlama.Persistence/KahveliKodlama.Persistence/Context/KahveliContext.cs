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
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
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
            }); ;

            modelBuilder.Entity<Member>()
               .HasMany(I => I.Contacts)
               .WithOne(I => I.Member)
               .HasForeignKey(I => I.MemberId);

            modelBuilder.Entity<Grade>().HasData(new Grade
            {
              GradeId=1,
              GradeName="Mezun",
              Section="a",
              
            }); ;
            modelBuilder.Entity<Student>().HasData(new Student
            {
               GradeId=1,
               StudentId=1,
               StudentName="Sefo"
            }); ;
            base.OnModelCreating(modelBuilder);

        }
        
    }
}
