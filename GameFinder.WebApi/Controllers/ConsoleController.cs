using GameFinder.Services.Console;
using Microsoft.AspNetCore.Mvc;

namespace GameFinder.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsoleController : ControllerBase
    {
        private readonly IConsoleService _consoleService;
        public ConsoleController(IConsoleService consoleService)
        {
            _consoleService = consoleService;
        }
    }
}
