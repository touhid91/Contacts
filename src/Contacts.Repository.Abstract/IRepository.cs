using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Contacts.Repository.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : class, new()
    {
        Task<TEntity> GetAsync();
        Task<IQueryable<TEntity>> GetAsync(Guid id);
        Task<IQueryable<TEntity>> GetAsync(params Guid[] keyValues);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IQueryable<TEntity>> GetAsync(int pageIndex, int pageSize);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, object>> sortingKeySelector, int pageIndex, int pageSize);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder, int pageIndex, int pageSize);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, object>> sortingKeySelector, Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder, Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize);

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        void Attach(TEntity entity);
        void Attach(IEnumerable<TEntity> entities);

        void Modify(TEntity entity);
        void Modify(IEnumerable<TEntity> entities);

        Task Remove(Guid id);
        Task Remove(params Guid[] keyValues);
        Task Remove(IEnumerable<TEntity> entities);

        Task CommitAsync();

    }
}
