using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Mattern.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission10_Mattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private readonly BowlingDbContext _context;

        public BowlingLeagueController(BowlingDbContext temp)
        {
            _context = temp;
        }

        [HttpGet(Name = "GetBowlingLeague")]
        public async Task<ActionResult<List<object>>> Get()
        {
            var BowlingList = await _context.Bowlers
                .Include(b => b.Team) // Join Team table to get TeamName
                .Select(b => new 
                {
                    b.BowlerID,
                    b.BowlerFirstName,
                    b.BowlerMiddleInit,
                    b.BowlerLastName,
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber,
                    b.TeamId,
                    TeamName = b.Team.TeamName // Get TeamName from the Team table
                })
                .ToListAsync();

            return Ok(BowlingList);
        }
    }
}
