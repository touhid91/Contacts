using System;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Contacts.Repository.Concrete
{
    public static class LinqExtensions
    {
        public static IOrderedQueryable<TEntity> OrderBy<TEntity, TKey>(this IQueryable<TEntity> queryable, Expression<Func<TEntity, TKey>> sortingKeySelector, SortOrder sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrder.Descending:
                    return queryable.OrderByDescending<TEntity, TKey>(sortingKeySelector);
                default:
                case SortOrder.Ascending:
                case SortOrder.Unspecified:
                    return queryable.OrderBy<TEntity, TKey>(sortingKeySelector);
            }
        }

        static int _pageIndex, _pageSize, _pagingSkipValue;
        public static IQueryable<TEntity> Paged<TEntity>(this IQueryable<TEntity> queryable, int pageIndex, int pageSize)
        {
            if (pageIndex != _pageIndex || pageSize != _pageSize)
            {
                _pageIndex = pageIndex;
                _pageSize = pageSize;
                _pagingSkipValue = (pageIndex - 1) * pageSize;
            }
            return queryable.Skip<TEntity>(_pagingSkipValue).Take<TEntity>(pageSize);
        }
    }
}
