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
        List<TEntity> GetAll(Expression<Func<TEntity, object>> includes);
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(int id);


    }
}
