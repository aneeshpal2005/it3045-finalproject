using it3045_finalproject.Data;
using it3045_finalproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace it3045_finalproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChipotleController : ControllerBase
    {
        private readonly ILogger<ChipotleController> _logger;
        private readonly DefaultContext _context;

        public ChipotleController(ILogger<ChipotleController> logger, DefaultContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetChipotleMenus")]
        [Route("/ChipotleMenus")]
        public IActionResult Get()
        {
            return Ok(_context.ChipotleMenus.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == null || id == 0)

                return Ok(_context.ChipotleMenus.Take(5).ToList());

            var item = _context.ChipotleMenus.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ChipotleMenu menu)
        {
            _context.ChipotleMenus.Add(menu);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = menu.ItemId }, menu);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ChipotleMenu updated)
        {
            var existing = _context.ChipotleMenus.Find(id);
            if (existing == null) return NotFound();
            existing.ItemName = updated.ItemName;
            existing.ItemType = updated.ItemType;
            existing.Description = updated.Description;
            existing.ItemCost = updated.ItemCost;
            _context.ChipotleMenus.Update(existing);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _context.ChipotleMenus.Find(id);
            if (existing == null) return NotFound();
            _context.ChipotleMenus.Remove(existing);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
