using asp.netcore_microservice.Dtos;
using asp.netcore_microservice.Models;
using asp.netcore_microservice.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace asp.netcore_microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepository platformRepository;
        private readonly IMapper mapper;
        public PlatformController(IPlatformRepository platformRepository, IMapper mapper)
        {
            this.platformRepository = platformRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Platform>> AddPlatform(PlatformCreateDto platform)
        {
            Console.WriteLine("--> Adding Platform...");
            return Ok(await platformRepository.AddPlatforms(mapper.Map<Platform>(platform)));
        }

        [HttpGet]
        public async Task<ActionResult<Platform>> GetPlatforms()
        {
            Console.WriteLine("--> Get All Platform...");
            return Ok(await platformRepository.GetAllPlatforms());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Platform>> GetPlatform(int id)
        {
            Console.WriteLine("--> Get Platform By Id...");
            return Ok(await platformRepository.GetPlatformById(id));
        }

        [HttpPut]
        public async Task<ActionResult<Platform>> UpdatePlatform(PlatformUpdateDto platform)
        {
            Console.WriteLine("--> Update Platform...");
            return Ok(await platformRepository.UpdatePlatform(mapper.Map<Platform>(platform)));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Platform>> DeletePlatform(int id)
        {
            Console.WriteLine("--> Delete Platform ById...");
            return Ok(await platformRepository.DeletePlatform(id));
        }
    }
}
