namespace ProjectAPI.Models
{
    public class Group : IEntity
    {
        public int GroupID { get; set; }
        public int OwnerUserID { get; set; }
        public string GroupName { get; set; }

        // Navigation properties
        public User Owner { get; set; }
        public ICollection<GroupMembership> GroupMemberships { get; set; }
        public GroupPage GroupPage { get; set; }
    }
}
