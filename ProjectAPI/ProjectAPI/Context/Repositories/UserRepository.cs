using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public UserRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
