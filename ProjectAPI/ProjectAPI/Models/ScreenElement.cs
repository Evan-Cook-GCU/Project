namespace ProjectAPI.Models
{
    public class ScreenElement : IEntity
    {
        public int ElementID { get; set; }
        public int PageID { get; set; }
        public string ElementType { get; set; }
        public string ElementConfig { get; set; } // JSON or similar format

        // Navigation property
        public GroupPage GroupPage { get; set; }
    }
}
