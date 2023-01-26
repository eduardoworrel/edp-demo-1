using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public WeatherForecastController(ApplicationDbContext context)
    {
        _context = context;
        // _preferenciasRepository = preferenciasRepository;
    }

    [HttpGet]
    public ActionResult<Preferencias> buscaPreferencia()
    {

        if(_context.Preferencias.Any()){
            return _context.Preferencias.First();
        }else{
           return NotFound();
        }
    }
    [HttpPost]
    public void SalvaPrefencia(PreferenciasViewModel preferenciasViewModel)
    {

        var preferencias = new Preferencias {
            ConteudoDinamico = preferenciasViewModel.ConteudoDinamico,
            CorDeFundo = preferenciasViewModel.CorDeFundo,
            CorDoTexto = preferenciasViewModel.CorDoTexto,
            TamanhoDaFonte = preferenciasViewModel.TamanhoDaFonte,
        };

        if(_context.Preferencias.Any()){
            preferencias.Id = 1;
            _context.Entry(preferencias).State = EntityState.Modified;
        }else{
            _context.Preferencias.Add(preferencias);
        }
         _context.SaveChanges();
        
    }
}
