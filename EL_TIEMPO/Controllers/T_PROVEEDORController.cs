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
    public class T_PROVEEDORController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public T_PROVEEDORController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/T_PROVEEDOR
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_PROVEEDOR>>> GetT_PROVEEDOR()
        {
          if (_context.T_PROVEEDOR == null)
          {
              return NotFound();
          }
            return await _context.T_PROVEEDOR.ToListAsync();
        }

        // GET: api/T_PROVEEDOR/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_PROVEEDOR>> GetT_PROVEEDOR(int id)
        {
          if (_context.T_PROVEEDOR == null)
          {
              return NotFound();
          }
            var t_PROVEEDOR = await _context.T_PROVEEDOR.FindAsync(id);

            if (t_PROVEEDOR == null)
            {
                return NotFound();
            }

            return t_PROVEEDOR;
        }

        // PUT: api/T_PROVEEDOR/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_PROVEEDOR(int id, T_PROVEEDOR t_PROVEEDOR)
        {
            if (id != t_PROVEEDOR.PROV_ID)
            {
                return BadRequest();
            }

            _context.Entry(t_PROVEEDOR).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_PROVEEDORExists(id))
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

        // POST: api/T_PROVEEDOR
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<T_PROVEEDOR>> PostT_PROVEEDOR(T_PROVEEDOR t_PROVEEDOR)
        {
          if (_context.T_PROVEEDOR == null)
          {
              return Problem("Entity set 'ApplicationDbContext.T_PROVEEDOR'  is null.");
          }
            _context.T_PROVEEDOR.Add(t_PROVEEDOR);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_PROVEEDOR", new { id = t_PROVEEDOR.PROV_ID }, t_PROVEEDOR);
        }

        // DELETE: api/T_PROVEEDOR/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteT_PROVEEDOR(int id)
        {
            if (_context.T_PROVEEDOR == null)
            {
                return NotFound();
            }
            var t_PROVEEDOR = await _context.T_PROVEEDOR.FindAsync(id);
            if (t_PROVEEDOR == null)
            {
                return NotFound();
            }

            _context.T_PROVEEDOR.Remove(t_PROVEEDOR);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool T_PROVEEDORExists(int id)
        {
            return (_context.T_PROVEEDOR?.Any(e => e.PROV_ID == id)).GetValueOrDefault();
        }
    }
}
