namespace Artoo.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface for a read only repository.
    /// </summary>
    public interface IReadOnlyRepository
    {
        Task<T> GetOneElement<T>(Expression<Func<T, bool>> where)
            where T : class, new();

        Task<T> GetOneElement<T>(Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take)
            where T : class, new();

        Task<IEnumerable<T>> GetManyElements<T>(Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take)
            where T : class, new();

        Task<T> GetFirstElement<T>(Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
            where T : class, new();

        Task<IEnumerable<T>> GetAllElements<T>()
            where T : class, new();

        Task<int> CountElements<T>(Expression<Func<T, bool>> where)
            where T : class, new();

        Task<bool> ElementExists<T>(Expression<Func<T, bool>> where)
            where T : class, new();
    }
}
