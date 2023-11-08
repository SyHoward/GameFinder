using GameFinder.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        
    //!Console
    public DbSet<ConsoleEntity> Consoles { get; set; }

    //!Game
    public DbSet<GameEntity> Games {get; set;} = null!;
}