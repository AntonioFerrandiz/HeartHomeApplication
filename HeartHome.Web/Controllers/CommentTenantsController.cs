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
    public class CommentTenantsController : ControllerBase
    {
        private readonly DbContextHeartHomeApp _context;

        public CommentTenantsController(DbContextHeartHomeApp context)
        {
            _context = context;
        }

        // GET: api/CommentTenants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentTenant>>> GetCommentTenants()
        {
            return await _context.CommentTenants.ToListAsync();
        }

        // GET: api/CommentTenants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentTenant>> GetCommentTenant(int id)
        {
            var commentTenant = await _context.CommentTenants.FindAsync(id);

            if (commentTenant == null)
            {
                return NotFound();
            }

            return commentTenant;
        }

        // PUT: api/CommentTenants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentTenant(int id, CommentTenant commentTenant)
        {
            if (id != commentTenant.CommentID)
            {
                return BadRequest();
            }

            _context.Entry(commentTenant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentTenantExists(id))
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

        // POST: api/CommentTenants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommentTenant>> PostCommentTenant(CommentTenant commentTenant)
        {
            _context.CommentTenants.Add(commentTenant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommentTenant", new { id = commentTenant.CommentID }, commentTenant);
        }

        // DELETE: api/CommentTenants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentTenant(int id)
        {
            var commentTenant = await _context.CommentTenants.FindAsync(id);
            if (commentTenant == null)
            {
                return NotFound();
            }

            _context.CommentTenants.Remove(commentTenant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentTenantExists(int id)
        {
            return _context.CommentTenants.Any(e => e.CommentID == id);
        }
    }
}
