using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Domain.Common;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.Repositories
{
    public class AsyncGenericRepository<TEntity> : IAsyncGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly KahveliContext _context;    

        public AsyncGenericRepository()
        {
            _context = EngineContext.Current.Resolve<KahveliContext>();
        }

        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>()
                         .AsNoTracking()
                         .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
