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
    public class T_RGU_USUARIOSController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public T_RGU_USUARIOSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/T_RGU_USUARIOS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_RGU_USUARIO>>> GetT_RGU_USUARIO()
        {
          if (_context.T_RGU_USUARIO == null)
          {
              return NotFound();
          }
            return await _context.T_RGU_USUARIO.ToListAsync();
        }

        // GET: api/T_RGU_USUARIOS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_RGU_USUARIO>> GetT_RGU_USUARIO(int id)
        {
          if (_context.T_RGU_USUARIO == null)
          {
              return NotFound();
          }
            var t_RGU_USUARIO = await _context.T_RGU_USUARIO.FindAsync(id);

            if (t_RGU_USUARIO == null)
            {
                return NotFound();
            }

            return t_RGU_USUARIO;
        }

        // PUT: api/T_RGU_USUARIOS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_RGU_USUARIO(int id, T_RGU_USUARIO t_RGU_USUARIO)
        {
            if (id != t_RGU_USUARIO.RGU_IDENTIFICACION)
            {
                return BadRequest();
            }

            _context.Entry(t_RGU_USUARIO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_RGU_USUARIOExists(id))
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

        // POST: api/T_RGU_USUARIOS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<T_RGU_USUARIO>> PostT_RGU_USUARIO(T_RGU_USUARIO t_RGU_USUARIO)
        {
          if (_context.T_RGU_USUARIO == null)
          {
              return Problem("Entity set 'ApplicationDbContext.T_RGU_USUARIO'  is null.");
          }
            _context.T_RGU_USUARIO.Add(t_RGU_USUARIO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_RGU_USUARIO", new { id = t_RGU_USUARIO.RGU_IDENTIFICACION }, t_RGU_USUARIO);
        }

        // DELETE: api/T_RGU_USUARIOS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteT_RGU_USUARIO(int id)
        {
            if (_context.T_RGU_USUARIO == null)
            {
                return NotFound();
            }
            var t_RGU_USUARIO = await _context.T_RGU_USUARIO.FindAsync(id);
            if (t_RGU_USUARIO == null)
            {
                return NotFound();
            }

            _context.T_RGU_USUARIO.Remove(t_RGU_USUARIO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool T_RGU_USUARIOExists(int id)
        {
            return (_context.T_RGU_USUARIO?.Any(e => e.RGU_IDENTIFICACION == id)).GetValueOrDefault();
        }
    }
}
