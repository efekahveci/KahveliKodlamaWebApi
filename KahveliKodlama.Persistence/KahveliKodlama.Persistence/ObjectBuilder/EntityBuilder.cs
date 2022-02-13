using KahveliKodlama.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.ObjectBuilder
{
    public abstract class EntityBuilder<TEntity> : IEntityBuilder where TEntity : BaseEntity
    {
        public abstract void MapEntity(ModelBuilder builder);
        
    }
}
