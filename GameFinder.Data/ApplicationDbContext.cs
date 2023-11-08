using GameFinder.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<ConsoleEntity> Consoles { get; set; }
}