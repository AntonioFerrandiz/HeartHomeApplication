using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeartHome.Data;
using HeartHome.Entities;

namespace HeartHome.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessorsController : ControllerBase
    {
        private readonly DbContextHeartHomeApp _context;

        public LessorsController(DbContextHeartHomeApp context)
        {
            _context = context;
        }

        // GET: api/Lessors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lessor>>> GetLessors()
        {
            return await _context.Lessors.ToListAsync();
        }

        // GET: api/Lessors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lessor>> GetLessor(int id)
        {
            var lessor = await _context.Lessors.FindAsync(id);

            if (lessor == null)
            {
                return NotFound();
            }

            return lessor;
        }

        // PUT: api/Lessors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLessor(int id, Lessor lessor)
        {
            if (id != lessor.LessorID)
            {
                return BadRequest();
            }

            _context.Entry(lessor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessorExists(id))
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

        // POST: api/Lessors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lessor>> PostLessor(Lessor lessor)
        {
            _context.Lessors.Add(lessor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLessor", new { id = lessor.LessorID }, lessor);
        }

        // DELETE: api/Lessors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLessor(int id)
        {
            var lessor = await _context.Lessors.FindAsync(id);
            if (lessor == null)
            {
                return NotFound();
            }

            _context.Lessors.Remove(lessor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LessorExists(int id)
        {
            return _context.Lessors.Any(e => e.LessorID == id);
        }
    }
}
