using ProjectAPI.Models;
using System.Linq.Expressions;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> : IDisposable where T : class, IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate, params string[] navigationProperties);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(T entityToUpdate);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TReturnType"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        IEnumerable<TReturnType> RunRawSql<TReturnType>(string sql);
    }
}
