namespace ProjectAPI.Models
{
    public class User : IEntity
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        // Other user-related properties

        // Navigation properties
        public ICollection<Group> OwnedGroups { get; set; }
        public ICollection<GroupMembership> GroupMemberships { get; set; }
    }
}
