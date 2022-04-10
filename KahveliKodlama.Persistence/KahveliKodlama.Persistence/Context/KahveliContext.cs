
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Persistence.ObjectBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace KahveliKodlama.Persistence.Context;

public class KahveliContext : DbContext
{

    public KahveliContext(DbContextOptions<KahveliContext> options) : base(options)
    {

    }

    public DbSet<Heading> Headings { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Content> Contents { get; set; }

    public DbSet<Mail> Mails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        var tp = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(type => typeof(IEntityBuilder).
          IsAssignableFrom(type) && !type.IsAbstract && !type.IsInterface).ToList();

        foreach (var typ in tp)
        {
            var act = (IEntityBuilder)Activator.CreateInstance(typ);

            act.MapEntity(modelBuilder);
        };

        base.OnModelCreating(modelBuilder);

    }

}
