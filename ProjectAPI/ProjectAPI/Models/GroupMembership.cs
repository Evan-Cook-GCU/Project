namespace ProjectAPI.Models
{
    public class GroupMembership : IEntity
    {
        public int MembershipID { get; set; }
        public int UserID { get; set; }
        public int GroupID { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Group Group { get; set; }
    }
}
