using KahveliKodlama.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace KahveliKodlama.Persistence.ObjectBuilder
{
    public abstract class EntityBuilder<TEntity> : IEntityBuilder where TEntity : BaseEntity
    {
        public abstract void MapEntity(ModelBuilder builder);
        
    }
}
