using asp.netcore_microservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcore_microservice.Repository
{
    public interface IPlatformRepository
    {
        Task<ActionResult<List<Platform>>> AddPlatforms(Platform platform);
        Task<ActionResult<List<Platform>>> GetAllPlatforms();
        Task<ActionResult<Platform>> GetPlatformById(int id);
        Task<ActionResult<List<Platform>>> UpdatePlatform(Platform platform);
        Task<ActionResult<List<Platform>>> DeletePlatform(int id);
    }
}
