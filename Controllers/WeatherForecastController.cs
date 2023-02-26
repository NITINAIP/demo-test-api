using demo_test_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace demo_test_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly GeneratedQR _GeneratedQR;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, GeneratedQR GeneratedQR)
    {
        _logger = logger;
        _GeneratedQR = GeneratedQR;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpPost(Name = "GeneratedQR"),]
    public ActionResult GeneratedQR(string text, string fileName)
    {
        try
        {
            _GeneratedQR.GeneratedBarcodesS(text, fileName);
            return Ok(new { StatusCode = 200 });
        }
        catch (System.Exception err)
        {
            return BadRequest(new { StatusCode = 400, LoggerMessage = err.Message.ToString() });
            throw;
        }

    }
}
