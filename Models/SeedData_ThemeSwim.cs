using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WEB315_Assignments_ThemeSwim.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ThemeSwimContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ThemeSwimContext>>()))
            {
                // Look for any movies.
                if (context.ThemeSwim.Any())
                {
                    return;   // DB has been seeded
                }

                context.ThemeSwim.AddRange(
                    new ThemeSwim
                    {
                        EventName = "International Aquatic Meet",
                        BookingDate = DateTime.Parse("2023-01-26"),
                        Competition = "World Championship ",
                        PoolName = "MP International Swimming Pool",
                        EntryPrice = 0.00M
                    },

                    new ThemeSwim
                    {
                        EventName = "National Aquatic Meet",
                        BookingDate = DateTime.Parse("2023-03-24"),
                        Competition = "National Level",
                        PoolName = "Varsity Aquatic Stadium",
                        EntryPrice = 20.00M
                    },

                    new ThemeSwim
                    {
                        EventName = "Swim To Win",
                        BookingDate = DateTime.Parse("2023-04-12"),
                        Competition = "Open to all",
                        PoolName = "Canadian Bay",
                        EntryPrice = 7.99M
                    },

                    new ThemeSwim
                    {
                        EventName = "Fun Swim",
                        BookingDate = DateTime.Parse("2023-05-10"),
                        Competition = "Open for all ",
                        PoolName = "Sentinels Pool",
                        EntryPrice = 7.99M
                    },

                    new ThemeSwim
                    {
                        EventName = "Young Champion",
                        BookingDate = DateTime.Parse("2023-06-19"),
                        Competition = "Under 18",
                        PoolName = "ARAQ International Pool",
                        EntryPrice = 2.00M
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}