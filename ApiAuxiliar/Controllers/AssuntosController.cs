#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiAuxiliar.Data;
using ApiAuxiliar.Models;

namespace ApiAuxiliar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssuntosController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public AssuntosController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Assuntos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assunto>>> GetAssuntos()
        {
            return await _context.Assuntos.ToListAsync();
        }

        // GET: api/Assuntos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assunto>> GetAssunto(int id)
        {
            var assunto = await _context.Assuntos.FindAsync(id);

            if (assunto == null)
            {
                return NotFound();
            }

            return assunto;
        }

        // PUT: api/Assuntos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssunto(int id, Assunto assunto)
        {
            if (id != assunto.AssuntoId)
            {
                return BadRequest();
            }

            _context.Entry(assunto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssuntoExists(id))
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

        // POST: api/Assuntos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Assunto>> PostAssunto(Assunto assunto)
        {
            _context.Assuntos.Add(assunto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssunto", new { id = assunto.AssuntoId }, assunto);
        }

        // DELETE: api/Assuntos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssunto(int id)
        {
            var assunto = await _context.Assuntos.FindAsync(id);
            if (assunto == null)
            {
                return NotFound();
            }

            _context.Assuntos.Remove(assunto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssuntoExists(int id)
        {
            return _context.Assuntos.Any(e => e.AssuntoId == id);
        }
    }
}
