using System;
using System.Linq;
using System.Linq.Expressions;

namespace Flower.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Marks an enity as new
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Marks an enity as modified
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        ///Marks an enity to be removed
        /// </summary>
        /// <param name="enity"></param>
        void Delete(T enity);

        /// <summary>
        /// Delete multi records
        /// </summary>
        /// <param name="where"></param>
        void Delete(Expression<Func<T, bool>> where);

        /// <summary>
        /// Get an entity by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetSingleById(int id);

        T GetSingleByCodition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0,int size = 50,string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckCotains(Expression<Func<T, bool>> predicate);
    }
}