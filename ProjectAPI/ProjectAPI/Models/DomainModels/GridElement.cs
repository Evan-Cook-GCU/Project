namespace ProjectAPI.Models.DomainModels
{
    public class GridElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int GridId { get; set; }

        public string Value { get; set; }
        public string Type { get; set; }
    }
}
