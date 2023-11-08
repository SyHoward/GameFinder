using GameFinder.Data;
using GameFinder.Data.Entities;
using GameFinder.Models.Console;

namespace GameFinder.Services.Console;
    public class ConsoleService : IConsoleService
{
    private readonly ApplicationDbContext _dbContext;

    public ConsoleService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ConsoleListItem?> CreateConsoleAsync(ConsoleCreate request)
    {
        ConsoleEntity entity = new()
        {
            Name = request.Name,
            Manufacturer = request.Manufacturer
        };

        _dbContext.Consoles.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (numberOfChanges != 1)
            return null;
        
        ConsoleListItem response = new()
        {
            Name = entity.Name
        };
        return response;
    }
}