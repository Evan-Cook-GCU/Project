namespace ProjectAPI.Models
{
  
        public abstract class GridItem : IEntity
        {
            public int GridItemId { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        public int GridId { get; set; }
            public GridEntity Grid { get; set; }
        }

    
}