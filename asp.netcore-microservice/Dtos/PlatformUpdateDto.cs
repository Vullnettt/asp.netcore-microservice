﻿using System.ComponentModel.DataAnnotations;

namespace asp.netcore_microservice.Dtos
{
    public class PlatformUpdateDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
