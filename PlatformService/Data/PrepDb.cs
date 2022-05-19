using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateAsyncScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            Console.WriteLine("Seeding Data...");
            if(!context.Platforms.Any())
            {
                context.Platforms.AddRange(
                    new Platform {Name="ASP Core",Publisher="Microsoft",Cost="Free"},
                    new Platform {Name="SQL Server Express",Publisher="Microsoft",Cost="Free"},
                    new Platform {Name="Kubernetes",Publisher="Cloud Native Foundation",Cost="Free"}
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Data Platform sudah ada");
            }
        }
    }
}