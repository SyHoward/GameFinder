
using GameFinder.Models.Console;

namespace GameFinder.Services.Console;
public interface IConsoleService
{
    Task<ConsoleListItem?> CreateConsoleAsync(ConsoleCreate request);
}