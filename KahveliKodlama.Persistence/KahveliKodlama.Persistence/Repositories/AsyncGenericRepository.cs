using KahveliKodlama.Application.Interfaces.Repositories;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Common;
using KahveliKodlama.Infrastructure.ContextEngine;
using KahveliKodlama.Persistence.Context;
using KahveliKodlama.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace KahveliKodlama.Persistence.Repositories
{
    public class AsyncGenericRepository<TEntity> : IAsyncGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly KahveliContext _context;    

        public AsyncGenericRepository()
        {
            _context = EngineContext.Current.Resolve<KahveliContext>();
        }

        public async Task Create(TEntity entity)
        {
            entity.CreatedTime = DateTime.UtcNow;

            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {

            var entity = await GetById(id);
            //  entity.DeleteTime = DateTime.Now;   
            //_context.Set<TEntity>().Remove(entity);
            //await _context.SaveChangesAsync();
            entity.DeleteTime = DateTime.UtcNow;
            entity.Status = false;
            _context.Set<TEntity>().Update(entity);

            await _context.SaveChangesAsync();
        }

        public Task<List<TEntity>> GetAll()
        {
            return  _context.Set<TEntity>()
                         .Where(x => x.Status == true).ToListAsync();
                
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, object>> includes)
        {
            return await _context.Set<TEntity>().Include(includes).ToListAsync();
                
        }
        
        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>()
                         .AsNoTracking()
                         .Where(x => x.Status == true)   
                         .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<TEntity> GetById(int id,Expression<Func<TEntity, object>> includes)
        {
            return await _context.Set<TEntity>()
                         .AsNoTracking()
                         .Include(includes)
                         .Where(x => x.Status == true)
                         .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task UniqueCreate(TEntity entity)
        {
            var result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e=>e.Id == entity.Id);

            if (result!=null)
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity entity)
        {

            //var updatedEntity = _context.Set<TEntity>().Entry(entity);
            //updatedEntity.State = EntityState.Modified;
            //await _context.SaveChangesAsync();



            //var result = await GetById(entity.Id);

          
            //await Update(retVal);

          //  return retVal;



            _context.Set<TEntity>().Update(entity);

            await _context.SaveChangesAsync();


            // Here model is model return from form on post
            //var oldobj = _context.Members.Where(x => x.Id == entity.Id).SingleOrDefault();


            //// Newly Inserted Code
            //var UpdatedObj = CheckUpdateObjectExtensions.CheckUpdateObject(oldobj, entity);

            //_context.Entry(oldobj).CurrentValues.SetValues(UpdatedObj);

            //await _context.SaveChangesAsync();
            //    var entries =_context.ChangeTracker
            //.Entries()
            //.Where(e => e.Entity is BaseEntity && (
            //        e.State == EntityState.Added
            //        || e.State == EntityState.Modified));

            //    foreach (var entityEntry in entries)
            //    {
            //        ((BaseEntity)entityEntry.Entity).LastModifyTime = DateTime.Now;

            //        if (entityEntry.State == EntityState.Added)
            //        {
            //            ((BaseEntity)entityEntry.Entity).CreatedTime = DateTime.Now;
            //        }
            //    }

        }

        
    }
}
