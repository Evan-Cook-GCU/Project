using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGroupPageRepository : IRepository<GroupPage>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class GroupPageRepository : Repository<GroupPage>, IGroupPageRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public GroupPageRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
