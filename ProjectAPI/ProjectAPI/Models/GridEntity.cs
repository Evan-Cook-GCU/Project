namespace ProjectAPI.Models
{
    public class GridEntity : IEntity
    {
        public int GridEntityId { get; set; }
        public string Name { get; set; }
        public ICollection<GridItem> GridItems { get; set; }
    }
}
