using it3045_finalproject.Data;
using it3045_finalproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace it3045_finalproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMemberController> _logger;
        private readonly DefaultContext _context;

        public TeamMemberController(ILogger<TeamMemberController> logger, DefaultContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetTeamMembers")]
        [Route("/")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.TeamMembers.ToList());
            }
            catch (SqlException sqlEx)
            {
                _logger.LogError(sqlEx, "SQL error occurred while fetching team member");
                return StatusCode(500, "Database error");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching team member");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var member = _context.TeamMembers.Find(id);
                if (member == null) return NotFound();
                return Ok(member);
            }
            catch (SqlException sqlEx)
            {
                _logger.LogError(sqlEx, "SQL error occurred while fetching team member by id");
                return StatusCode(500, "Database error");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching team member by id");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Models.TeamMember member)
        {
            try
            {
                _context.TeamMembers.Add(member);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetById), new { id = member.TeamMemberId }, member);
            }
            catch (SqlException sqlEx)
            {
                _logger.LogError(sqlEx, "SQL error occurred while creating team member");
                return StatusCode(500, "Database error");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating team member");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Models.TeamMember updated)
        {
            try
            {
                var existing = _context.TeamMembers.Find(id);
                if (existing == null) return NotFound();

                existing.TeamMemberName = updated.TeamMemberName;
                existing.TeamMemberBirthdate = updated.TeamMemberBirthdate;
                existing.TeamMemberProgram = updated.TeamMemberProgram;
                existing.TeamMemberYear = updated.TeamMemberYear;

                _context.TeamMembers.Update(existing);
                _context.SaveChanges();
                return NoContent();
            }
            catch (SqlException sqlEx)
            {
                _logger.LogError(sqlEx, "SQL error occurred while updating team member");
                return StatusCode(500, "Database error");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating team member");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var existing = _context.TeamMembers.Find(id);
                if (existing == null) return NotFound();

                _context.TeamMembers.Remove(existing);
                _context.SaveChanges();
                return NoContent();
            }
            catch (SqlException sqlEx)
            {
                _logger.LogError(sqlEx, "SQL error occurred while deleting team member");
                return StatusCode(500, "Database error");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting team member");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
