namespace ProjectAPI.services.WeatherForecast.Create
{
    public interface ICreateWeatherForecast
    {
        int Invoke(Models.DomainModels.WeatherForecast model);
    }
}