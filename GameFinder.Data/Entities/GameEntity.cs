using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Data.Entities;

public class GameEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(1)]
    public string Name { get; set; } = string.Empty;

    [Required]
    //Foreign Key
    public string Genre { get; set; } = string.Empty;

    [Required]
    //Foreign Key
    public string GameConsole { get; set; } = string.Empty;

    [Required]
    //Foreign Key
    public string Publisher { get; set; } = string.Empty;

    [Required]
    //Foreign Key
    public string DevTeam { get; set; } = string.Empty;
}