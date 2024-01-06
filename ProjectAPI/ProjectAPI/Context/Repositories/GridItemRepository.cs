using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGridItemRepository : IRepository<GridItem>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class GridItemRepository : Repository<GridItem>, IGridItemRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public GridItemRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
