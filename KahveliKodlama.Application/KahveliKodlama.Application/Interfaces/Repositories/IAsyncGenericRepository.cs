using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KahveliKodlama.Application.Interfaces.Repositories;

public interface IAsyncGenericRepository<TEntity> where TEntity : class
{

    IQueryable<TEntity> GetAllQuery { get; }

    IQueryable<TEntity> GetAllQueryInc(Expression<Func<TEntity, object>> includes);
    Task<TEntity> GetById(string id);
    Task<TEntity> GetByIdInc(string id, Expression<Func<TEntity, object>> includes);
    Task Create(TEntity entity);
    Task UniqueCreate(TEntity entity);

    Task Update(TEntity entity);

    Task Delete(string id);


}
