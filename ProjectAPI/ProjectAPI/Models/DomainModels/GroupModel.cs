namespace ProjectAPI.Models.DomainModels
{
    public class GroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public List<UserModel> Users { get; set; }
        public int Rating { get; set; } = 2;
        public GridModel Grid { get; set; }
        public List<DataModel> Data { get; set; }
        public List<MetricModel> MetricElements { get; set; }
    }
}

