using System.ComponentModel.DataAnnotations;

namespace GameFinder.Models.Console;
public class ConsoleCreate
{
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Manufacturer { get; set; } = string.Empty;
}
