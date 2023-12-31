using Microsoft.AspNetCore.Mvc;
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
        public static List<WeatherForecast> _forecasts = new List<WeatherForecast>();  
        public WeatherForecastController(ILogger<WeatherForecastController> logger,ICreateWeatherForecast create)
        {
            _createWeatherForecast = create;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _forecasts
            .ToArray();
        }
        [HttpGet("{id}")]
        public WeatherForecast Get(int id)
        {
            if(1!=_createWeatherForecast.Invoke(new WeatherForecast()))
            {
                Console.WriteLine("Error");
            }
            try
            {
                if (_forecasts[id] != null)
                {
                    Response.StatusCode = 200;
                    return _forecasts[id];
                }else
                {
                    Response.StatusCode = 404;
                    return null;
                }
            } catch (ArgumentOutOfRangeException)
            {
                Response.StatusCode = 404;
                return null;
            }
           
        }
        [HttpGet("/test")]
        public IEnumerable<WeatherForecast> Get(string test)
        {
            DateTime date = DateTime.Now;
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = date,
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

        }
        [HttpPost]
        public ActionResult<WeatherForecast> Post([FromBody] WeatherForecast forecast)
        {
            forecast.Id = _forecasts.Count;
            _forecasts.Add(forecast);
            return CreatedAtAction(nameof(Get), new { id = forecast.Id }, forecast);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WeatherForecast forecast)
        {
            // Add your logic to update the forecast
            // For example, _repository.Update(id, forecast);
            try
            {
                _forecasts[id]=forecast;
                return Ok(forecast);
            } catch (ArgumentOutOfRangeException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Add your logic to delete the forecast
            // For example, _repository.Delete(id);
            try
            {
                _forecasts[id]=null;
                return Ok();
            } catch (ArgumentOutOfRangeException)
            {
                return NotFound();
            }
        }
    }
}
