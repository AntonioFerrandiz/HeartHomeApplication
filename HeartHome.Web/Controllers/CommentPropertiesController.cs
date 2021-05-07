using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeartHome.Data;
using HeartHome.Entities;
using HeartHome.Web.Models;

namespace HeartHome.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentPropertiesController : ControllerBase
    {
        private readonly DbContextHeartHomeApp _context;

        public CommentPropertiesController(DbContextHeartHomeApp context)
        {
            _context = context;
        }

        // GET: api/CommentProperties
        [HttpGet]
        public async Task<IEnumerable<CommentPropertyModel>> GetCommentProperties()
        {
            var propertyList = await _context.CommentProperties.ToListAsync();

            return propertyList.Select(c => new Models.CommentPropertyModel
            {
                CommentID = c.CommentID,
                TenantID = c.TenantID,
                Date = c.Date,
                Detail = c.Detail
            });
        }

        // GET: api/CommentProperties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentProperty>> GetCommentProperty(int id)
        {
            var commentProperty = await _context.CommentProperties.FindAsync(id);

            if (commentProperty == null)
            {
                return NotFound();
            }

            return commentProperty;
        }

        // PUT: api/CommentProperties/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentProperty(int id, CommentProperty commentProperty)
        {
            if (id != commentProperty.CommentID)
            {
                return BadRequest();
            }

            _context.Entry(commentProperty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentPropertyExists(id))
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

        // POST: api/CommentProperties
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommentProperty>> PostCommentProperty(CommentProperty commentProperty)
        {
            _context.CommentProperties.Add(commentProperty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommentProperty", new { id = commentProperty.CommentID }, commentProperty);
        }

        // DELETE: api/CommentProperties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentProperty(int id)
        {
            var commentProperty = await _context.CommentProperties.FindAsync(id);
            if (commentProperty == null)
            {
                return NotFound();
            }

            _context.CommentProperties.Remove(commentProperty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentPropertyExists(int id)
        {
            return _context.CommentProperties.Any(e => e.CommentID == id);
        }
    }
}
