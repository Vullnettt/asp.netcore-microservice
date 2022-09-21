using System.ComponentModel.DataAnnotations;

namespace asp.netcore_microservice.Dtos
{
    public class PlatformNameDto
    {
        [Required]
        public string Name { get; set; }
    }
}
