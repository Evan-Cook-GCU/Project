using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGridEntityRepository : IRepository<GridEntity>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class GridEntityRepository : Repository<GridEntity>, IGridEntityRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public GridEntityRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
