using System.ComponentModel.DataAnnotations;

namespace asp.netcore_microservice.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
