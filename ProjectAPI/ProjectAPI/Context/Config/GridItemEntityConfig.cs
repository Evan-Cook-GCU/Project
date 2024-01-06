using System.Data.Entity.ModelConfiguration;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Config
{
    public class GridItemEntityConfig: EntityTypeConfiguration<GridItem>
    {

        public GridItemEntityConfig()
        {  
            // This is the only change from GridEntityEntityConfig.cs
            this.ToTable("GridItem").HasKey(c=>c.GridItemId);
            this.Property(c=>c.GridItemId).HasColumnName("GridItemId");
            this.HasRequired(c=>c.Grid).WithMany(c=>c.GridItems).HasForeignKey(c=>c.GridId);
           
        }
        
    }
}
