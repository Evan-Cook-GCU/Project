using System.Data.Entity.ModelConfiguration;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Config
{
    public class GroupEntityConfig: EntityTypeConfiguration<Group>
    {

        public GroupEntityConfig()
        {
            this.ToTable("Group").HasKey(c=>c.GroupID);
            this.Property(c => c.GroupID).HasColumnName("GroupId");
            this.Property(c=>c.GroupName).HasColumnName("GroupName");
            this.HasRequired(c=>c.Owner).WithMany().HasForeignKey(c=>c.OwnerUserID);
            this.HasRequired(global => global.GroupMemberships).WithMany().HasForeignKey(c => c.GroupID);
            
           
        }
        /*
         *public int GroupID { get; set; }
        public int OwnerUserID { get; set; }
        public string GroupName { get; set; }

        // Navigation properties
        public User Owner { get; set; }
        public ICollection<GroupMembership> GroupMemberships { get; set; }
        public GroupPage GroupPage { get; set; }
        */

    }
}
