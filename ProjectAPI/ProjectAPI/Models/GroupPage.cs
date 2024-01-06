namespace ProjectAPI.Models
{
    public class GroupPage : IEntity
    {
        public int PageID { get; set; }
        public int GroupID { get; set; }
        public string LayoutConfig { get; set; } // JSON or similar format

        // Navigation properties
        public Group Group { get; set; }
        public ICollection<ScreenElement> ScreenElements { get; set; }
    }
}
