using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services.Validators;

namespace Presentation.Controllers;

[ApiController]
[Route("v1/api/post")]
public class PostagemController : ControllerBase
{

    private IBaseService<Postagem> _basePostagemService;
    public PostagemController(IBaseService<Postagem> basePostagemService)
    {
        _basePostagemService = basePostagemService;
    }

    [HttpPost]
    public IActionResult Create([FromBody] Postagem Postagem)
    {
        if (Postagem == null)
            return NotFound();

        return Execute(() => _basePostagemService.Add<PostagemValidator>(Postagem).Id);
    }

    [HttpPut]
    public IActionResult Update([FromBody] Postagem Postagem)
    {
        if (Postagem == null)
            return NotFound();

        return Execute(() => _basePostagemService.Update<PostagemValidator>(Postagem));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id == 0)
            return NotFound();

        Execute(() =>
        {
            _basePostagemService.Delete(id);
            return true;
        });

        return new NoContentResult();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Execute(() => _basePostagemService.Get());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id == 0)
            return NotFound();

        return Execute(() => _basePostagemService.GetById(id));
    }

    private IActionResult Execute(Func<object> func)
    {
        try
        {
            var result = func();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
