using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Common;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace KahveliKodlama.Persistence.Repositories;

public class AsyncGenericRepository<TEntity> : IAsyncGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    private readonly KahveliContext _context;

    public AsyncGenericRepository()
    {
        _context = EngineContext.Current.Resolve<KahveliContext>();
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();



    public IQueryable<TEntity> GetAllQuery => Table.AsNoTracking().Where(x => x.Status == true).OrderByDescending(x => x.CreatedTime).AsQueryable();


    public async Task Create(TEntity entity)
    {
        entity.CreatedTime = DateTime.UtcNow;

        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(string id)
    {

        var entity = await GetById(id);
        entity.DeleteTime = DateTime.UtcNow;
        entity.Status = false;
        Table.Update(entity);
        await _context.SaveChangesAsync();
    }



    public IQueryable<TEntity> GetAllQueryInc(Expression<Func<TEntity, object>> includes)
    {
        return Table.Include(includes).AsNoTracking().Where(x => x.Status == true).AsQueryable();
    }


    public async Task<TEntity> GetById(string id)
    {
        var result = await Table.FindAsync(Guid.Parse(id));

        if (result.Status != true)
            return null;
        else return result;
    }
    public async Task<TEntity> GetByIdInc(string id, Expression<Func<TEntity, object>> includes)
    {
        return await Table
                     .AsNoTracking()
                     .Include(includes)
                     .Where(x => x.Status == true)
                     .FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
    }



    public async Task UniqueCreate(TEntity entity)
    {
        var result = await Table.AsNoTracking().FirstOrDefaultAsync(e => e.Id == entity.Id);

        if (result != null)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task Update(TEntity entity)
    {

        Table.Update(entity);

        await _context.SaveChangesAsync();






    }

}
