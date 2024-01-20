using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models.DomainModels;

public interface IProjectContext
{
    DbSet<GridElementModel> GridElement { get; set; }
    DbSet<GridModel> Grids { get; set; }
    DbSet<GroupModel> Groups { get; set; }
    DbSet<UserModel> Users { get; set; }
    DbSet<WeatherForecastDomainModel> WeatherForecasts { get; set; }
}