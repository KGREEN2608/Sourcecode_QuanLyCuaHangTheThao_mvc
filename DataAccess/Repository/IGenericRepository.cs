using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IGenericRepository<TEntity>  where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>>? expression = null, params string[] includeProperties);
        Task<TEntity?> GetFirst(Expression<Func<TEntity, bool>>? expression = null, params string[] includeProperties);
    }
}
