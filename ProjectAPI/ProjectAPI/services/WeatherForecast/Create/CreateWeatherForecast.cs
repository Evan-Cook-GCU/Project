using ProjectAPI.Context.Repositories;
using ProjectAPI.Context.UnitOfWork;

namespace ProjectAPI.services.WeatherForecast.Create
{
    public class CreateWeatherForecast : ICreateWeatherForecast
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        //constructor
        public CreateWeatherForecast(IUnitOfWork unitOfWork,IWeatherForecastRepository weatherForecastRepository )
        {
            _unitOfWork = unitOfWork;
            _weatherForecastRepository = weatherForecastRepository;
        }
        public int Invoke(Models.WeatherForecast model)
        {
             _weatherForecastRepository.Insert(model);
            _unitOfWork.Save();
            return model.Id;
        }
    }
}
