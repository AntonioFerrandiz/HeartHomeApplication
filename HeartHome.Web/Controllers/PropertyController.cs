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
    }
}
