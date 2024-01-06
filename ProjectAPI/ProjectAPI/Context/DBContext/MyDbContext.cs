using ProjectAPI.Models;
using System.Data.Entity;

namespace ProjectAPI.Context.DBContext
{


    public class MyDbContext : DbContext, IMyDbContext
    {
        public MyDbContext() : base("BooksConnection")
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        // Define other DbSet properties for your entities

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            return SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveAsync()
        {
            return await SaveChangesAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public new IDbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ModelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Configurations.AddFromAssembly(typeof(MyDbContext).Assembly);
        }
        /// <summary>
        /// 
        /// </summary>
        public new void Dispose()
        {
            base.Dispose();
        }
    }

}
