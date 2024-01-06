using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ProjectAPI.Context.Repositories
{
    public class Repository<T> : IDisposable, IRepository<T> where T : class, IEntity
    {
        private readonly IMyDbContext _database;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public Repository(IMyDbContext database)
        {
            _database = database;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return _database.Set<T>().AsQueryable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
        {
            var query = _database.Set<T>().AsQueryable();

            foreach (string navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            return query.Where(predicate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual T GetSingle(Expression<Func<T, bool>> predicate)
        {
            var query = _database.Set<T>().AsQueryable();

            return query.FirstOrDefault(predicate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(T entity)
        {
            _database.Set<T>().Add(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            var entity = _database.Set<T>().Find(id);

            Delete(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(T entity)
        {
            _database.Set<T>().Remove(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(T entityToUpdate)
        {
            var context = (DbContext)_database;
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TReturnType"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public IEnumerable<TReturnType> RunRawSql<TReturnType>(string sql)
        {
            var context = (DbContext)_database;
            return context.Database.SqlQuery<TReturnType>(sql);
        }

        #region IDisposable Support
        private bool disposedValue = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _database.Dispose();
                }
                disposedValue = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
