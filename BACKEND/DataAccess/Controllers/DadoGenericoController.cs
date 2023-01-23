using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;

namespace DataAccess.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadoGenericoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DadoGenericoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DadoGenerico
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DadoGenerico>>> GetDadoGenerico()
        {
          if (_context.DadoGenerico == null)
          {
              return NotFound();
          }
            return await _context.DadoGenerico.ToListAsync();
        }

        // GET: api/DadoGenerico/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DadoGenerico>> GetDadoGenerico(int id)
        {
          if (_context.DadoGenerico == null)
          {
              return NotFound();
          }
            var dadoGenerico = await _context.DadoGenerico.FindAsync(id);

            if (dadoGenerico == null)
            {
                return NotFound();
            }

            return dadoGenerico;
        }

        // PUT: api/DadoGenerico/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDadoGenerico(int id, DadoGenerico dadoGenerico)
        {
            if (id != dadoGenerico.Id)
            {
                return BadRequest();
            }

            _context.Entry(dadoGenerico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DadoGenericoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DadoGenerico
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DadoGenerico>> PostDadoGenerico(DadoGenerico dadoGenerico)
        {
          if (_context.DadoGenerico == null)
          {
              return Problem("Entity set 'ApplicationDbContext.DadoGenerico'  is null.");
          }
            _context.DadoGenerico.Add(dadoGenerico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDadoGenerico", new { id = dadoGenerico.Id }, dadoGenerico);
        }

        // DELETE: api/DadoGenerico/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDadoGenerico(int id)
        {
            if (_context.DadoGenerico == null)
            {
                return NotFound();
            }
            var dadoGenerico = await _context.DadoGenerico.FindAsync(id);
            if (dadoGenerico == null)
            {
                return NotFound();
            }

            _context.DadoGenerico.Remove(dadoGenerico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DadoGenericoExists(int id)
        {
            return (_context.DadoGenerico?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
