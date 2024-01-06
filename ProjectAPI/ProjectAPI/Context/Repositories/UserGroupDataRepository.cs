using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserGroupDataRepository : IRepository<UserGroupData>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class UserGroupDataRepository : Repository<UserGroupData>, IUserGroupDataRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public UserGroupDataRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
