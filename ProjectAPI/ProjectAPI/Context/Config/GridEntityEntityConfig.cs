using System.Data.Entity.ModelConfiguration;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Config
{
    public class GridEntityEntityConfig: EntityTypeConfiguration<GridEntity>
    {

        public GridEntityEntityConfig()
        {
            this.ToTable("GridEntity").HasKey(c=>c.GridEntityId);
            this.Property(c => c.GridEntityId).HasColumnName("GridEntityId");
            this.Property(c=>c.Name).HasColumnName("Name");
            this.HasMany(c=>c.GridItems).WithRequired().HasForeignKey(c=>c.GridItemId);
           
        }
        
        
    }
}
