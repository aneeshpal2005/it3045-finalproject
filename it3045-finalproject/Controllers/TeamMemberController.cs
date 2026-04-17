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

    }
}
