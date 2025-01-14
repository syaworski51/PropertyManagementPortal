using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using PropertyManagementPortalAPI.Models;
using PropertyManagementPortalAPI.Services;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropertyManagementPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly MongoCollectionService<Property> _properties;

        public PropertiesController(MongoCollectionService<Property> properties)
        {
            _properties = properties;
        }
        
        // GET: api/<PropertiesController>
        [HttpGet]
        public async Task<ActionResult<List<Property>>> Get()
        {
            return Ok(await _properties.GetAllAsync());
        }

        // GET api/<PropertiesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> Get(ObjectId id)
        {
            return Ok(await _properties.GetByIdAsync(id));
        }

        // POST api/<PropertiesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Property property)
        {
            await _properties.CreateAsync(property);
            return CreatedAtAction(nameof(Get), new { id = property.Id }, property);
        }

        // PUT api/<PropertiesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(ObjectId id, [FromBody] Property updatedProperty)
        {
            if (id != updatedProperty.Id)
                return BadRequest("The IDs in the URL and request body do not match.");

            var property = await _properties.GetByIdAsync(id);
            if (property == null)
                return NotFound($"There is no property with ID \"{id}\".");

            await _properties.UpdateAsync(id, updatedProperty);
            return NoContent();
        }

        // DELETE api/<PropertiesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(ObjectId id)
        {
            var property = _properties.GetByIdAsync(id);
            if (property == null)
                return NotFound($"There is no property with ID \"{id}\".");

            await _properties.DeleteAsync(id);
            return NoContent();
        }
    }
}
