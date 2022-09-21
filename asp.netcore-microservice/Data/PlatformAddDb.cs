using asp.netcore_microservice.Models;

namespace asp.netcore_microservice.Data
{
    public static class PlatformAddDb
    {
        public static void AddDatabase(IApplicationBuilder app) 
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                Data(serviceScope.ServiceProvider.GetService<PlatformDbContext>());
            }
        }

        private static void Data(PlatformDbContext platformDb)
        {
            if (!platformDb.platforms.Any())
            {
                Console.WriteLine("--> Add Data In PlatformDbContext...");

                platformDb.platforms.AddRange(
                    new Platform { Name = "Gta 5", Publisher = "Rocstar", Price = 20},
                    new Platform { Name = ".Net", Publisher = "Microsoft", Price = 0},
                    new Platform { Name = "Java", Publisher = "Oracle", Price = 0 }
                    );
                platformDb.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We Already Have Data...");
            }
        }
    }
}
