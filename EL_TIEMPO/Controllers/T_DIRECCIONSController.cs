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
    public class T_DIRECCIONSController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public T_DIRECCIONSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/T_DIRECCIONS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_DIRECCION>>> GetT_DIRECCION()
        {
          if (_context.T_DIRECCION == null)
          {
              return NotFound();
          }
            return await _context.T_DIRECCION.ToListAsync();
        }

        // GET: api/T_DIRECCIONS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_DIRECCION>> GetT_DIRECCION(int id)
        {
          if (_context.T_DIRECCION == null)
          {
              return NotFound();
          }
            var t_DIRECCION = await _context.T_DIRECCION.FindAsync(id);

            if (t_DIRECCION == null)
            {
                return NotFound();
            }

            return t_DIRECCION;
        }

        // PUT: api/T_DIRECCIONS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_DIRECCION(int id, T_DIRECCION t_DIRECCION)
        {
            if (id != t_DIRECCION.DIR_ID)
            {
                return BadRequest();
            }

            _context.Entry(t_DIRECCION).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_DIRECCIONExists(id))
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

        // POST: api/T_DIRECCIONS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<T_DIRECCION>> PostT_DIRECCION(T_DIRECCION t_DIRECCION)
        {
          if (_context.T_DIRECCION == null)
          {
              return Problem("Entity set 'ApplicationDbContext.T_DIRECCION'  is null.");
          }
            _context.T_DIRECCION.Add(t_DIRECCION);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_DIRECCION", new { id = t_DIRECCION.DIR_ID }, t_DIRECCION);
        }

        // DELETE: api/T_DIRECCIONS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteT_DIRECCION(int id)
        {
            if (_context.T_DIRECCION == null)
            {
                return NotFound();
            }
            var t_DIRECCION = await _context.T_DIRECCION.FindAsync(id);
            if (t_DIRECCION == null)
            {
                return NotFound();
            }

            _context.T_DIRECCION.Remove(t_DIRECCION);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool T_DIRECCIONExists(int id)
        {
            return (_context.T_DIRECCION?.Any(e => e.DIR_ID == id)).GetValueOrDefault();
        }
    }
}
