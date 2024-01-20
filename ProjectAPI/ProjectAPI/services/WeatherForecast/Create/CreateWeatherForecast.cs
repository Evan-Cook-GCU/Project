using ProjectAPI.Models.DomainModels;

namespace ProjectAPI.services.WeatherForecast.Create
{
    public class CreateWeatherForecast : ICreateWeatherForecast
    {
        private readonly IRepository<WeatherForecastDomainModel> _repo;
        //constructor
        public CreateWeatherForecast()
        {
            
        }
        public int Invoke(WeatherForecastDomainModel model)
        {
            using var context = new ProjectContext();
            context.WeatherForecasts.Add(model);
            context.SaveChanges();
            return model.Id;
        }
    }
}
