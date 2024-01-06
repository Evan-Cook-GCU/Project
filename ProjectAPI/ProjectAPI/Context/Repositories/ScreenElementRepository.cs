using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IScreenElementRepository : IRepository<ScreenElement>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class ScreenElementRepository : Repository<ScreenElement>, IScreenElementRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public ScreenElementRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
