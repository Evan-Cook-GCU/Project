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
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Grid> Grids { get; set; }
    public DbSet<GridElement> GridElement { get; set; }


}
