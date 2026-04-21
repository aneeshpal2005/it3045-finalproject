using it3045_finalproject.Data;
using Microsoft.AspNetCore.Mvc;

namespace it3045_finalproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbiesController
    {
        private readonly ILogger<HobbiesController> _logger;
        private readonly DefaultContext _context;
        public HobbiesController(ILogger<HobbiesController> logger, DefaultContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new OkObjectResult(_context.Hobbies.ToList());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching hobbies");
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{id?}")]
        public IActionResult GetById(int? id)
        {
            if (id == null || id == 0)
            {
                return new OkObjectResult(_context.Hobbies.Take(5).ToList());
            }
            var hobby = _context.Hobbies.Find(id);
            if (hobby == null) return new NotFoundResult();
            return new OkObjectResult(hobby);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Models.Hobbies hobby)
        {
            _context.Hobbies.Add(hobby);
            _context.SaveChanges();
            return new CreatedAtActionResult(nameof(GetById), "Hobbies", new { id = hobby.Id }, hobby);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Models.Hobbies updated)
        {
            var existing = _context.Hobbies.Find(id);
            if (existing == null) return new NotFoundResult();
            existing.Name = updated.Name;
            existing.Description = updated.Description;
            existing.HobbiesId = updated.HobbiesId;
            _context.Hobbies.Update(existing);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _context.Hobbies.Find(id);
            if (existing == null) return new NotFoundResult();
            _context.Hobbies.Remove(existing);
            _context.SaveChanges();
            return new NoContentResult();
        }

    }
}
