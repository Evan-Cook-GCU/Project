using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace ProjectAPI.Context.Config
{
    public class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            
        }
    }
}
