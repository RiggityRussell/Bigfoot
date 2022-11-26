using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bigfoot.Data;
using System;
using System.Linq;

namespace Bigfoot.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BigfootContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BigfootContext>>()))
            {
                // Look for any cryptids.
                if (context.Sightings.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sightings.AddRange(
                    new Sightings
                    {
                        Location = "Michigan",
                        Validity = 9.5,
                        Description = "Humanoid Woodland Ape.",
                        Photo = 1
                    },
                    new Sightings
                    {
                        Location = "Florida",
                        Validity = 2,
                        Description = "Humanoid Woodland Ape.",
                        Photo = 1
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
