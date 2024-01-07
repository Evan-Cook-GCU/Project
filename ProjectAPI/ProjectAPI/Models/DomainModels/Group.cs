namespace ProjectAPI.Models.DomainModels
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public List<User> Users { get; set; }
        public int Rating { get; set; } = 2;
    }
}

