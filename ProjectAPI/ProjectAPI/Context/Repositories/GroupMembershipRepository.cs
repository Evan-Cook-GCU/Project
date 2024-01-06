using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGroupMembershipRepository : IRepository<GroupMembership>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class GroupMembershipRepository : Repository<GroupMembership>, IGroupMembershipRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public GroupMembershipRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
