using asp.netcore_microservice.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.netcore_microservice.Data
{
    public class PlatformDbContext : DbContext
    {
        public PlatformDbContext(DbContextOptions<PlatformDbContext> options) : base(options)
        {

        }

        public DbSet<Platform> platforms { get; set; }
    }
}
