using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework5
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchResults : ControllerBase
    {
        private readonly IMatchResultsService matchResultsService;

        public MatchResultsController(IMatchResultsService matchResultsService)
        {
            this.matchResultsService = matchResultsService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertMatchResults(MatchResults matchResults)
            }
}

