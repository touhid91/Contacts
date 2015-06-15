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
        private readonly DbSet<TEntity> _dbSet;
        private readonly Contacts.Entity.ContactsModel _dbContext;

        public Repository(Contacts.Entity.ContactsModel context)
        {
            if (context == null)
                throw new ArgumentNullException();
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        Task<TEntity> IRepository<TEntity>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(params Guid[] keyValues)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, System.Data.SqlClient.SortOrder sortOrder, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAsync(System.Linq.Expressions.Expression<Func<TEntity, object>> sortingKeySelector, System.Data.SqlClient.SortOrder sortOrder, System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository<TEntity>.CountAsync()
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository<TEntity>.CountAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Attach(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Attach(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Modify(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Modify(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        Task IRepository<TEntity>.Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<TEntity>.Remove(params Guid[] keyValues)
        {
            throw new NotImplementedException();
        }

        Task IRepository<TEntity>.Remove(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        Task IRepository<TEntity>.CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
