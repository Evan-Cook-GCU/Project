using ProjectAPI.Context.DBContext;
using ProjectAPI.Models;

namespace ProjectAPI.Context.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWeatherForecastRepository : IRepository<WeatherForecast>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class WeatherForecastRepository : Repository<WeatherForecast>, IWeatherForecastRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public WeatherForecastRepository(IMyDbContext database) : base(database)
        {
        }
    }
}
