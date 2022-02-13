using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.ObjectBuilder
{
    public interface IEntityBuilder
    {
        void MapEntity(ModelBuilder builder);
    }
}
