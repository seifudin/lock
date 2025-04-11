using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{

    public class Carsmodel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public double? Year { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Engine { get; set; }
        public string? Transmission { get; set; }
        public string? Drive { get; set; }
        public string? Meleage { get; set; }
        public string? Power { get; set; }
    }
}
