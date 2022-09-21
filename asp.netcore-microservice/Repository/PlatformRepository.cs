using asp.netcore_microservice.Data;
using asp.netcore_microservice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.netcore_microservice.Repository
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly PlatformDbContext platformDb;
        public PlatformRepository(PlatformDbContext platformDb)
        {
            this.platformDb = platformDb;
        }

        public async Task<ActionResult<List<Platform>>> AddPlatforms(Platform platform)
        {
            platformDb.platforms.Add(platform);
            await platformDb.SaveChangesAsync();
            return await platformDb.platforms.ToListAsync();
        }

        public async Task<ActionResult<List<Platform>>> DeletePlatform(int id)
        {
            var deletePlatformById = await platformDb.platforms.FindAsync(id);
            platformDb.platforms.Remove(deletePlatformById);
            await platformDb.SaveChangesAsync();
            return await platformDb.platforms.ToListAsync();
        }

        public async Task<ActionResult<List<Platform>>> GetAllPlatforms()
        {
            return await platformDb.platforms.ToListAsync();
        }

        public async Task<ActionResult<Platform>> GetPlatformById(int id)
        {
            return await platformDb.platforms.FindAsync(id);
        }

        public async Task<ActionResult<List<Platform>>> UpdatePlatform(Platform platform)
        {
            var platformUpdate = await platformDb.platforms.FindAsync(platform.Id);
            platformUpdate.Name = platform.Name;
            platformUpdate.Publisher = platform.Publisher;
            platformUpdate.Price = platform.Price;
            await platformDb.SaveChangesAsync();
            return await platformDb.platforms.ToListAsync();
        }
    }
}
