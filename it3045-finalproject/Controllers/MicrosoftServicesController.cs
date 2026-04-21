using it3045_finalproject.Data;
using it3045_finalproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace it3045_finalproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MicrosoftServicesController : ControllerBase
    {
        private readonly ILogger<MicrosoftServicesController> _logger;
        private readonly DefaultContext _context;

        public MicrosoftServicesController(ILogger<MicrosoftServicesController> logger, DefaultContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.MicrosoftServices.ToList());
        }

        [HttpGet("{id?}")]
        public IActionResult GetById(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.MicrosoftServices.Take(5).ToList());
            }
            var svc = _context.MicrosoftServices.Find(id);
            if (svc == null) return NotFound();
            return Ok(svc);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MicrosoftServices service)
        {
            _context.MicrosoftServices.Add(service);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = service.ServiceId }, service);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] MicrosoftServices updated)
        {
            var existing = _context.MicrosoftServices.Find(id);
            if (existing == null) return NotFound();
            existing.ServiceName = updated.ServiceName;
            existing.ServiceDescription = updated.ServiceDescription;
            existing.ServiceCategory = updated.ServiceCategory;
            existing.SubscriptionCost = updated.SubscriptionCost;
            _context.MicrosoftServices.Update(existing);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _context.MicrosoftServices.Find(id);
            if (existing == null) return NotFound();
            _context.MicrosoftServices.Remove(existing);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
