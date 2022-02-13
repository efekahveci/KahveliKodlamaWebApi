using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KahveliKodlama.Domain.Common;

namespace KahveliKodlama.Application.Interfaces.Repositories
{
    public interface IAsyncGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, object>> includes);
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task<TEntity> GetById(int id, Expression<Func<TEntity, object>> includes);


        Task Create(TEntity entity);
        Task UniqueCreate(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(int id);


    }
}
