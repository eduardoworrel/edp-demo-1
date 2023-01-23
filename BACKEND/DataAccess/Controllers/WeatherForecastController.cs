using Microsoft.AspNetCore.Mvc;
using Data;

namespace DataAccess.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public WeatherForecastController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IEnumerable<string>> Get(string valor)
    {
        var result = _context.DadoGenerico
        .FirstOrDefault(e => e.Valor == valor);
        if(result == null){
            return NotFound();
        }else{
            return new JsonResult(
                new {
                    key = result.Chave,
                    valor = result.Valor
                }
            );
        }
        
    }
}
