using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace ProjectAPI.Context.Config
{
    public class GroupMembershipEntityConfig : EntityTypeConfiguration<GroupMembership>
    {
        public GroupMembershipEntityConfig()
        {
            // Configure GroupMembership entity here
            HasKey(m => m.MembershipID);

            HasRequired(m => m.User)
               .WithMany(u => u.GroupMemberships)
               .HasForeignKey(m => m.UserID);

            HasRequired(m => m.Group)
               .WithMany(g => g.GroupMemberships)
               .HasForeignKey(m => m.GroupID);
        }
    }
}
