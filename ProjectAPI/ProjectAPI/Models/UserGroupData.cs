namespace ProjectAPI.Models
{
    public class UserGroupData: IEntity
    {
        public int DataID { get; set; }
        public int UserID { get; set; }
        public int GroupID { get; set; }
        public string DataContent { get; set; } // JSON or similar format

        // Navigation properties
        public User User { get; set; }
        public Group Group { get; set; }
    }
}
