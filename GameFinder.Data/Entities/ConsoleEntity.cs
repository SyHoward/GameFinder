using System.ComponentModel.DataAnnotations;

namespace GameFinder.Data.Entities;
public class ConsoleEntity
{
        //* Id (primary key)
        [Key]
        public int Id { get; set; }
        [Required]
        //* Console Name
        public string Name { get; set; } = string.Empty;
        [Required]
        //* Console Manufacturer
        public string Manufacturer {get; set; } = string.Empty;
        
}