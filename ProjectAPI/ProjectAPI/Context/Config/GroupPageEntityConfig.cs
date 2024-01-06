using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace ProjectAPI.Context.Config
{
    public class GroupPageEntityConfiguration : EntityTypeConfiguration<GroupPage>
    {
        public GroupPageEntityConfiguration()
        {
            
        }
    }
}
