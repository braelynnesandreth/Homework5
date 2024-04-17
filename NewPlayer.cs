using Homework5.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Homework5
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewPlayer : ControllerBase
    {

        private readonly INewPlayerService newPlayerService;
        public NewPlayer(INewPlayerService newPlayerService, INewPlayerService newPlayerService) : this(newPlayerService)
        {
            this.newPlayerService = newPlayerService;

        }
        [HttpPost]
        public async Task<IActionResult> InsertNewPlayer(NewPlayerModel newPlayer)
}
}

