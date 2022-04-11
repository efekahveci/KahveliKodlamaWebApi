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

            entity.Property(e => e.Image).HasDefaultValue("Empty");
            entity.Property(e => e.Age).HasDefaultValue(Convert.ToInt16(1));
            entity.Property(e => e.About).HasDefaultValue("Empty");
            entity.Property(e => e.Title).HasDefaultValue("Empty");
            entity.Property(e => e.Authority).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.CreatedTime).HasDefaultValueSql("now()");
            entity.Property(e => e.LastModifyTime).HasDefaultValueSql("now()");

        });





    }
}
