using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AuthenticationController : ControllerBase
  {


    private readonly ILogger<AuthenticationController> _logger;

    public AuthenticationController(ILogger<AuthenticationController> logger)
    {
      _logger = logger;
    }

    [HttpGet(Name = "user")]
    public IEnumerable<WeatherForecast> Get()
    {
      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = Random.Shared.Next(-20, 55),
      })
      .ToArray();
    }
  }
}