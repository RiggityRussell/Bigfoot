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
                        State = "Ohio",
                        Month = "May",
                        Year = "1988",
                        Class = "B",
                        Occurence = "Campers had small stones thrown at their tent. Also heard grunting noises similiar to an ape.",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Campers were accosted by BigFoot and heard it making noises, no physical sighting or contact.",
                        /*PhotoPath = "bigfoot.jpg"*/
                    },
                    new Sightings
                    {
                        State = "Florida",
                        Month = "January",
                        Year = "2005",
                        Class = "A",
                        Occurence = "While fishing a man saw what could only be BigFoot.",
                        Location = "Miami",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                        
                    },

                    new Sightings
                    {
                        State = "Washington",
                        Month = "July",
                        Year = "2015",
                        Class = "B",
                        Occurence = "Hikers frightened by BigFoot crossing a path in front of them.",
                        Location = "Pacific County",
                        Description = "While walking a couple of hikers were spooked by a BigFoot who was ambling across the path in front of them, he was large and covered in fur, thankfully not aggressive.",
                        
                    },

                    new Sightings
                    {
                        State = "Illinois",
                        Month = "August",
                        Year = "2003",
                        Class = "A",
                        Occurence = "A man witnessed BigFoot swimming in a lake.",
                        Location = "Lake County",
                        Description = "While fishing a man noticed a large creatures head swimming accross a lake, he was surprised when it got out a few hundred feet from him and was a BigFoot who disappeared quickly into the woods when observed.",
                        
                    },

                    new Sightings
                    {
                        State = "Michigan",
                        Month = "March",
                        Year = "2007",
                        Class = "B",
                        Occurence = "A woman witnessed BigFoot from her kitchen window.",
                        Location = "Grand Traverse County",
                        Description = "A woman washing dishes witnessed a shadowy figure covered in fur in the woods behind her house.",
                        
                    },

                    new Sightings
                    {
                        State = "Texas",
                        Month = "September",
                        Year = "2017",
                        Class = "A",
                        Occurence = "A Cowboy watching his flock witnessed a BigFoot carrying a sheep off.",
                        Location = "Denton",
                        Description = "A Cowboy tending to his sheep witnessed a BigFoot carry a sheep off in the dusk, when it would be able to escape into darkness and not be found."
                        
                    },

                    new Sightings
                    {
                        State = "California",
                        Month = "May",
                        Year = "1979",
                        Class = "A",
                        Occurence = "Sighting off Indian Road behind isolated (at the time) Desert Hot Springs Condo complex",
                        Location = "Riverside County",
                        Description = "Was going back to close shop at approx. 10PM in the northern desert above Palm Springs, CA., and saw a huge light tan colored biped with soft blowing hair .Because I was in a small VW bug with the light pointing down into the street upon leaving the driveway facing out into the desert.\r\n\r\nI froze there with my dim headlight on it and it too froze there completely still,. I flashed my worthless high beams at it and it took 2 giant steps backwards and then one to my left, it's right and was gone into the dark. I was overcome with severe fear, panic and anxiety, and had to return home again.",
                        
                    },

                    new Sightings
                    {
                        State = "Washington",
                        Month = "April",
                        Year = "2003",
                        Class = "A",
                        Occurence = "Nighttime sighting by motorist on KM Hill near Skamokawa",
                        Location = "Wahkiakum County",
                        Description = "On 4-24-03, my friend was driving home from work from Naselle, WA to Puget Island, WA around 12:30 a.m. on Highway 4 (Wahkiakum County, WA). He observed a large bipedal animal (approx. 6 to 8 feet tall) broad shouldered with dark bluish/grey hair walking down a steep slope on the other side of the guardrail at the top of KM Hill.",                      
                    },

                    new Sightings
                    {
                        State = "Oregon",
                        Month = "March",
                        Year = "1985",
                        Class = "B",
                        Occurence = "Possible Injured Juvenile on I-84 near Boardman",
                        Location = "Morrow",
                        Description = "While driving the road started to bend south a bit and we came to the first incline and in the headlights of my truck appeared this figure, at first I thought it was some animal that was crossing the road but as we got closer and the lights of the truck became more focused on it, we realized that it was not a common anima!\r\n\r\nIt looked to be about three to four feet tall with the strangest red colored hair covering it's body. But the thing is, it was sitting in the road facing us with one leg straight out and the other leg out to it's right side, and it was trying to push itself up (as if it had been hit by a car).",                      
                    },
                    new Sightings
                    {
                        State = "Nebraska",
                        Month = "May",
                        Year = "2018",
                        Class = "B",
                        Occurence = "Possible daylight sighting of a Sasquatch on the Omaha Indian Reservation.",
                        Location = "Thurston County",
                        Description = "Hikers in the morning witnessed a BigFoot sighting.",
                        
                    },
                    new Sightings
                    {
                        State = "Nebraska",
                        Month = "December",
                        Year = "1979",
                        Class = "A",
                        Occurence = "Creature seen walking across pasture in daylight north of Grand Island.",
                        Location = "Howard County",
                        Description = "Farmer checking on livestock witnessed a Bigfoot.",
                    },
                    new Sightings
                    {
                        State = "North Dakota",
                        Month = "September",
                        Year = "2005",
                        Class = "A",
                        Occurence = "Multiple witness sighting near White Shield",
                        Location = "McLean County",
                        Description = "On Aug 26 around 2:20-2:30am my two cousins were driving back from Minot, they took the back roads to get home faster. They were about 2-3 miles from home on Counrty Road 7 when they said that they were just talking and notice on the left side in the North bound lane a large brown hairy 7-8ft tall thing was standing there, they said they were going about 50-55mph and slowed down a bit, as they passed by it they taped on the brake and in the brake lights they saw it and punched it back home, they said they were so scared that they were going aleast 90mph to get back.",
                    },
                    new Sightings
                    {
                        State = "Nevada",
                        Month = "February",
                        Year = "2005",
                        Class = "B",

                        Occurence = "Hikers spot a dark figure walking on a snowy mountainside near Winnemucca",
                        Location = "Humboldt",
                        Description = "Two hikers observed a BigFoot like creature while hiking up a snowy Mountainside near Winnemucca, the hikers are assured they were the only humans out there that day.",
                    },
                    new Sightings
                    {
                        State = "New Mexico",
                        Month = "July",
                        Year = "2020",
                        Class = "B",
                        Occurence = "Possible Sasquatch wood knocks in forested riverbed beside Chama during lockdown",
                        Location = "Rio Arriba County",
                        Description = "A couple of elderly hikers walking their dogs during lockdown observed loud knocking noises that resonated throughout the forest. Heard but not observed.",
                    },
                    new Sightings
                    {
                        State = "South Dakota",
                        Month = "June",
                        Year = "2019",
                        Class = "B",
                        Occurence = "Possible howls heard 4 miles north of Rochford in middle of Black Hills",
                        Location = "Pennington County",
                        Description = "A visitor at a family farm heard howling and screaming that went on for many minutes. The howling was enough to scare all animals and humans into silence.",
                    },
                    new Sightings
                    {
                        State = "Montana",
                        Month = "April",
                        Year = "2020",
                        Class = "A",
                        Occurence = "Sighting by trucker on Hwy 90 at Lookout Pass outside Tammany",
                        Location = "Mineral County",
                        Description = "Trucker had a very good look at a long reddish haired bigfoot standing up right on the back side of concrete barrier, long reddish brown hair. Couldn’t get a height since it was on other side of barrier.",
                    },
                    new Sightings
                    {
                        State = "Utah",
                        Month = "September",
                        Year = "2022",
                        Class = "A",
                        Occurence = "Late night sighting 15 miles SE of Heber City near Hwy 40",
                        Location = "HWY 40",
                        Description = "Brief sighting of it walking downhill through the trees on edge of Daniel's summit lodge property. Approximately 100 yards away from the cabin we were staying in. Awoke from our 2 dogs being agitated by the cabins open window. Wife walked to the window and observed large figure walking through the trees for a brief time before disappearing behind a structure.",
                    },
                    new Sightings
                    {
                        State = "Arizona",
                        Month = "August",
                        Year = "2021",
                        Class = "A",
                        Occurence = "20 miles east of Petrified Forest National Park -- motorhome driver and wife report daylight sighting from Interstate 40",
                        Location = "HWY 40",
                        Description = "Heading west on I-40 today at 0930 my wife and I saw a Bigfoot 100-150 yards from the hwy heading north. It was not running, but walking. It never looked at the hwy. It must have been 7-8 ft tall. It was thick, as in well built!",
                    },
                    new Sightings
                    {
                        State = "Oklahoma",
                        Month = "August",
                        Year = "2022",
                        Class = "B",
                        Occurence = "Big howls heard by property owner, stones throw from OK/AR border near Mena AR",
                        Location = "La Flore County",
                        Description = "I have lived in the area east of hwy 259 and hwy 63 also known as Big Cedar for 36 years. I was outside my home and I heard 7-10 howlings to the north. It was a sound I've never heard in the area before. I've spent considerable time in these woods. Hunting fishing as a teen I would camp alone with my squirrel dog. The only time I've heard anything like it was on TV during the big foot shows.",
                    },
                    new Sightings
                    {
                        State = "Colorado",
                        Month = "May",
                        Year = "2020",
                        Class = "B",
                        Occurence = "Hikers find large footprint and unidentified droppings",
                        Location = "Chaffee County",
                        Description = "I noticed animal droppings that appeared large human shaped under the uphill undergrowth, spaced every 10-20ft. I commented on the size and shape of the droppings with my wife and agreed they couldn’t be human as there were too many and under the branches of the uphill side We discussed how they appeared to be marking a territory. The droppings continued for maybe 150ft. We continue down/East on the trail. At about the 1/2 mile marrk a deer startled us running from the uphill side across the trail and down the other side. My wife was spooked and we turned around to go back. As we neared the spot where the droppings were I spotted a single foot print on the uphill side partly hidden by branches.",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
