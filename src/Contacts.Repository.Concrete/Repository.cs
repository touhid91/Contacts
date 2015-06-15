using Contacts.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Repository.Concrete
{
    public class Repository<TEntity>
        : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly DbSet<TEntity> _dbSet;
        protected readonly Contacts.Entity.ContactsModel _dbContext;

        public Repository(Contacts.Entity.ContactsModel context)
        {
            if (context == null)
                throw new ArgumentNullException();
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<TEntity> Get(params Guid[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }

        public IQueryable<TEntity> Get()
        {
            return _dbSet.AsQueryable<TEntity>();
        }

        public IQueryable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where<TEntity>(predicate);
        }

        public IQueryable<TEntity> Get(int pageIndex, int pageSize)
        {
            return _dbSet.Paged(pageIndex, pageSize);
        }

        public IQueryable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize)
        {
            return _dbSet.Where<TEntity>(predicate).Paged(pageIndex, pageSize);
        }

        public IQueryable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, int pageIndex, int pageSize)
        {
            return _dbSet.OrderBy<TEntity, object>(sortingKeySelector).Paged(pageIndex, pageSize);
        }

        public IQueryable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, System.Data.SqlClient.SortOrder sortOrder, int pageIndex, int pageSize)
        {
            return _dbSet.OrderBy<TEntity, object>(sortingKeySelector, sortOrder).Paged(pageIndex, pageSize);
        }

        public IQueryable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, int pageIndex, int pageSize)
        {
            return _dbSet.Where<TEntity>(predicate).OrderBy<TEntity, object>(sortingKeySelector).Paged(pageIndex, pageSize);
        }

        public IQueryable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, System.Data.SqlClient.SortOrder sortOrder, int pageIndex, int pageSize)
        {
            return _dbSet.Where<TEntity>(predicate).OrderBy<TEntity, object>(sortingKeySelector, sortOrder).Paged(pageIndex, pageSize);
        }

        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync<TEntity>();
        }

        public Task<int> CountAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Attach(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Modify(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task Remove(params Guid[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task Remove(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
