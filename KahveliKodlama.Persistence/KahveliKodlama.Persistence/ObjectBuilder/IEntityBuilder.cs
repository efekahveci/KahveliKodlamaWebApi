using Microsoft.EntityFrameworkCore;

namespace KahveliKodlama.Persistence.ObjectBuilder
{
    public interface IEntityBuilder
    {
        void MapEntity(ModelBuilder builder);
    }
}
