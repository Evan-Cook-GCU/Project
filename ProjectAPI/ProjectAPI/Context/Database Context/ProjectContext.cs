using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models.DomainModels;

public class ProjectContext : DbContext
{
    /*public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options)
    { 
        
    }*/
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=ProjectDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
    // Define DbSets for domain models here
    public DbSet<WeatherForecastDomainModel> WeatherForecasts { get; set; }
    public DbSet<UserModel> Users { get; set; }
    public DbSet<ImageModel> Images { get; set; }
    public DbSet<GroupModel> Groups { get; set; }
    public DbSet<GridModel> Grids { get; set; }
    public DbSet<GridElementModel> GridElement { get; set; }
    public DbSet<MetricModel> Metrics { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<DataModel> Data { get; set; }



}
