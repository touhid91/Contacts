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
        Task<TEntity> Get(params Guid[] keyValues);
        IQueryable<TEntity> Get();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Get(int pageIndex, int pageSize);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize);
        IQueryable<TEntity> Get(Expression<Func<TEntity, object>> sortingKeySelector, int pageIndex, int pageSize);
        IQueryable<TEntity> Get(Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder, int pageIndex, int pageSize);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> sortingKeySelector, int pageIndex, int pageSize);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder, int pageIndex, int pageSize);

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        void Attach(TEntity entity);
        void Attach(IEnumerable<TEntity> entities);

        void Modify(TEntity entity);
        void Modify(IEnumerable<TEntity> entities);

        Task Remove(params Guid[] keyValues);
        Task Remove(IEnumerable<TEntity> entities);

        Task CommitAsync();

    }
}
