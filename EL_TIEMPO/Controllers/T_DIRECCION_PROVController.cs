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
    public class T_DIRECCION_PROVController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public T_DIRECCION_PROVController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/T_DIRECCION_PROV
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_DIRECCION_PROV>>> GetT_DIRECCION_PROV()
        {
          if (_context.T_DIRECCION_PROV == null)
          {
              return NotFound();
          }
            return await _context.T_DIRECCION_PROV.ToListAsync();
        }

        // GET: api/T_DIRECCION_PROV/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_DIRECCION_PROV>> GetT_DIRECCION_PROV(int id)
        {
          if (_context.T_DIRECCION_PROV == null)
          {
              return NotFound();
          }
            var t_DIRECCION_PROV = await _context.T_DIRECCION_PROV.FindAsync(id);

            if (t_DIRECCION_PROV == null)
            {
                return NotFound();
            }

            return t_DIRECCION_PROV;
        }

        // PUT: api/T_DIRECCION_PROV/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_DIRECCION_PROV(int id, T_DIRECCION_PROV t_DIRECCION_PROV)
        {
            if (id != t_DIRECCION_PROV.DIRPROV_ID)
            {
                return BadRequest();
            }

            _context.Entry(t_DIRECCION_PROV).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_DIRECCION_PROVExists(id))
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

        // POST: api/T_DIRECCION_PROV
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<T_DIRECCION_PROV>> PostT_DIRECCION_PROV(T_DIRECCION_PROV t_DIRECCION_PROV)
        {
          if (_context.T_DIRECCION_PROV == null)
          {
              return Problem("Entity set 'ApplicationDbContext.T_DIRECCION_PROV'  is null.");
          }
            _context.T_DIRECCION_PROV.Add(t_DIRECCION_PROV);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_DIRECCION_PROV", new { id = t_DIRECCION_PROV.DIRPROV_ID }, t_DIRECCION_PROV);
        }

        // DELETE: api/T_DIRECCION_PROV/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteT_DIRECCION_PROV(int id)
        {
            if (_context.T_DIRECCION_PROV == null)
            {
                return NotFound();
            }
            var t_DIRECCION_PROV = await _context.T_DIRECCION_PROV.FindAsync(id);
            if (t_DIRECCION_PROV == null)
            {
                return NotFound();
            }

            _context.T_DIRECCION_PROV.Remove(t_DIRECCION_PROV);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool T_DIRECCION_PROVExists(int id)
        {
            return (_context.T_DIRECCION_PROV?.Any(e => e.DIRPROV_ID == id)).GetValueOrDefault();
        }
    }
}
