using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeartHome.Data;
using HeartHome.Entities;
using HeartHome.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly DbContextHeartHomeApp _context;
        public PropertyController(DbContextHeartHomeApp context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IEnumerable<PropertyModel>> GetProperties()
        {
            var propertyList = await _context.Properties.ToListAsync();
            return propertyList.Select(c => new PropertyModel
            {
                PropertyID = c.PropertyID,
                CityID = c.CityID,
                LessorID = c.LessorID,
                Type = c.Type,
                Address = c.Address,
                Name = c.Name
            });
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetPropertyByID([FromRoute] int id)
        {
            var property = await _context.Properties.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(new PropertyModel
            {
                PropertyID = property.PropertyID,
                CityID = property.CityID,
                LessorID = property.LessorID,
                Type = property.Type,
                Address = property.Address,
                Name = property.Name
            });
        }
        [HttpPost]
        public async Task<IActionResult> PostProperty([FromBody] CreatePropertyModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Property property = new Property
            {
                Name = model.Name,
                Type = model.Type,
                Address = model.Address
            };
            _context.Properties.Add(property);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();

        }
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> PutCategory([FromBody] UpdatePropertyModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model.PropertyID <= 0)
                return BadRequest();

            var property = await _context.Properties.FirstOrDefaultAsync(c => c.PropertyID == model.PropertyID);

            if (property == null)
                return NotFound();

            property.Name = model.Name;
            property.Type = model.Type;
            property.Address = model.Address;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty([FromRoute] int id)
        {
            var property = await _context.Properties.FindAsync(id);

            if (property == null)
                return NotFound();

            _context.Properties.Remove(property);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
