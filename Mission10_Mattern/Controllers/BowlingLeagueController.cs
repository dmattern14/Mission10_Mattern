using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Mattern.Data;

namespace Mission10_Mattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private BowlingDbContext _context;
        
        public BowlingLeagueController(BowlingDbContext temp)
        {
            _context = temp;
        }

        [HttpGet(Name = "GetBowlingLeague")]
        public List<Bowler> Get()
        {
            var BowlingList = _context.Bowlers.ToList();
            return (BowlingList);
        }
    }
}

