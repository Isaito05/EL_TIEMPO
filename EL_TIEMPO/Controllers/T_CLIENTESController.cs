using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EL_TIEMPO;
using MI_TERRAZA.Models;

namespace EL_TIEMPO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class T_CLIENTESController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public T_CLIENTESController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/T_CLIENTES
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_CLIENTE>>> GetT_CLIENTE()
        {
          if (_context.T_CLIENTE == null)
          {
              return NotFound();
          }
            return await _context.T_CLIENTE.ToListAsync();
        }

        // GET: api/T_CLIENTES/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_CLIENTE>> GetT_CLIENTE(int id)
        {
          if (_context.T_CLIENTE == null)
          {
              return NotFound();
          }
            var t_CLIENTE = await _context.T_CLIENTE.FindAsync(id);

            if (t_CLIENTE == null)
            {
                return NotFound();
            }

            return t_CLIENTE;
        }

        // PUT: api/T_CLIENTES/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_CLIENTE(int id, T_CLIENTE t_CLIENTE)
        {
            if (id != t_CLIENTE.CLI_ID)
            {
                return BadRequest();
            }

            _context.Entry(t_CLIENTE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_CLIENTEExists(id))
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

        // POST: api/T_CLIENTES
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<T_CLIENTE>> PostT_CLIENTE(T_CLIENTE t_CLIENTE)
        {
          if (_context.T_CLIENTE == null)
          {
              return Problem("Entity set 'ApplicationDbContext.T_CLIENTE'  is null.");
          }
            _context.T_CLIENTE.Add(t_CLIENTE);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_CLIENTE", new { id = t_CLIENTE.CLI_ID }, t_CLIENTE);
        }

        // DELETE: api/T_CLIENTES/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteT_CLIENTE(int id)
        {
            if (_context.T_CLIENTE == null)
            {
                return NotFound();
            }
            var t_CLIENTE = await _context.T_CLIENTE.FindAsync(id);
            if (t_CLIENTE == null)
            {
                return NotFound();
            }

            _context.T_CLIENTE.Remove(t_CLIENTE);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool T_CLIENTEExists(int id)
        {
            return (_context.T_CLIENTE?.Any(e => e.CLI_ID == id)).GetValueOrDefault();
        }
    }
}
