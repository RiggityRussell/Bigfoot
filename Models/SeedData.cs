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
                if (context == null || context.Sightings == null)
                {
                    throw new ArgumentNullException("Null BigfootContext");
                }
                // Look for any cryptids.
                if (context.Sightings.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sightings.AddRange(
                    new Sightings
                    {
                        State = "Alaska",
                        Month = "May",
                        Year = 1998,
                        Class = "A",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Campers had small stones thrown at their tent.  Also heard grunting noises similiar to an ape.",
                        //PhotoPath = "bigfoot.jpg"
                    },
                    new Sightings
                    {
                        State = "Florida",
                        Month = "January",
                        Year = 2005,
                        Class = "B",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        //PhotoPath = "bigfoot.jpg"
                    },

                    new Sightings
                    {
                        State = "Washington",
                        Month = "July",
                        Year = 2005,
                        Class = "B",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        //PhotoPath = "bigfoot.jpg"
                    },

                    new Sightings
                    {
                        State = "Oregon",
                        Month = "August",
                        Year = 2005,
                        Class = "C",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        //PhotoPath = "bigfoot.jpg"
                    },

                    new Sightings
                    {
                        State = "Michigan",
                        Month = "March",
                        Year = 2005,
                        Class = "B",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        //PhotoPath = "bigfoot.jpg"
                    },

                    new Sightings
                    {
                        State = "Texas",
                        Month = "September",
                        Year = 2005,
                        Class = "A",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails." +
                        "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW" +
                        "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW",
                        //PhotoPath = "bigfoot.jpg"
                    },

                    new Sightings
                    {
                        State = "California",
                        Month = "February",
                        Year = 2005,
                        Class = "C",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        //PhotoPath = "bigfoot.jpg"
                    },

                    new Sightings
                    {
                        State = "Washington",
                        Month = "March",
                        Year = 2005,
                        Class = "B",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        //PhotoPath = "bigfoot.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
