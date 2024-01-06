using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGroupRepository : IRepository<Group>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public GroupRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
