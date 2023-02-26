using demo_test_api.Model;
using demo_test_api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace demo_test_api.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly GeneratedQR _GeneratedQR;

    public FibonacciController(ILogger<WeatherForecastController> logger, GeneratedQR GeneratedQR)
    {
        _logger = logger;
        _GeneratedQR = GeneratedQR;
    }

    [HttpGet(Name = "GetFibonacci")]
    public ActionResult Get(int numberOfCount)
    {
        // if (numberOfCount < 2) return BadRequest(new { StatusCode = 400, message = "Please Enter a number greater than two" });
        int num, a = 0, b = 1, c = 0;
        num = numberOfCount;
        string resultStep = "";
        for (int i = 2; i <= num; i++)
        {
            c = a + b;
            resultStep = resultStep + $"{c} ";
            a = b;
            b = c;


            if (i == num) resultStep += $"nextVal = {a + b}";

        }
        return Ok(new { input = numberOfCount, id = Guid.NewGuid(), result = c, StatusCode = 200, resultStep = resultStep });
    }
    [HttpDelete(Name = "DeleteFibonacci")]
    public ActionResult Delete([FromBody] IList<dtoFibonacci> dtoFibonaccis, string id)
    {
        var req = dtoFibonaccis;
        List<dtoFibonacci> result = dtoFibonaccis.Where<dtoFibonacci>(r => r.id != id).ToList();
        return Ok(result);
    }


}
