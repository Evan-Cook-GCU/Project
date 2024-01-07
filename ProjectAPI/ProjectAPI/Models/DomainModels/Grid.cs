namespace ProjectAPI.Models.DomainModels
{
    public class Grid
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GridElement> GridElements { get; set; }
        public int groupId { get; set; }
    }
}