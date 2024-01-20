using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models.DomainModels;
using ProjectAPI.services.WeatherForecast.Create;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICreateWeatherForecast _createWeatherForecast;
        //create a list of weather forecasts
        public static List<WeatherForecastDomainModel> _forecasts = new List<WeatherForecastDomainModel>(); 
        private readonly IRepository<WeatherForecastDomainModel> _repo;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ICreateWeatherForecast create
    
            )
        {
            _logger = logger;
            _createWeatherForecast = create;
            _repo = new Repository<WeatherForecastDomainModel>(new ProjectContext());
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecastDomainModel> Get()
        {
            return _repo.GetAll();
        }
        [HttpGet("{id}")]
        public WeatherForecastDomainModel Get(int id)
        {
           return _repo.Get(id);
           
        }
        
        [HttpPost]
        public ActionResult<WeatherForecastDomainModel> Post([FromBody] WeatherForecastDomainModel forecast)
        {
            _createWeatherForecast.Invoke(forecast);
            return CreatedAtAction(nameof(Get),forecast);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WeatherForecastDomainModel forecast)
        {
            _repo.Update(forecast);
            return NoContent();
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var forecast = _repo.Get(id);
            if (forecast == null)
            {
                return NotFound();
            }
            _repo.Delete(forecast);
            return NoContent();
          
        }
    }
}
