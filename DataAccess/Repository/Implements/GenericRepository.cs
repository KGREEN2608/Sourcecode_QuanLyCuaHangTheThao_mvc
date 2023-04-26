using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repository.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly QuanLyCuaHangTheThaoContext _context;
        protected DbSet<TEntity> _entities;
        public GenericRepository()
        {
            _context = new QuanLyCuaHangTheThaoContext();
            _entities = _context.Set<TEntity>();
        }
        public virtual async Task<TEntity> Add(TEntity entity)
        {
            try
            {
                var nE = _entities.Add(entity).Entity;
                await _context.SaveChangesAsync();
                return nE;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public virtual async Task<bool> Delete(TEntity entity)
        {
            try
            {
                _entities.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public virtual async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>>? expression = null, params string[] includeProperties)
        {
            IQueryable<TEntity>? query = _entities;
            query = expression == null ? query : query.Where(expression);
            if (includeProperties != null)
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }
            }
            return await query.ToListAsync();
        }

        public virtual async Task<TEntity?> GetFirst(Expression<Func<TEntity, bool>>? expression = null, params string[] includeProperties) => (await Get(expression, includeProperties)).FirstOrDefault();

        public virtual async Task<bool> Update(TEntity entity)
        {
            try
            {
                _entities.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


    }
}
