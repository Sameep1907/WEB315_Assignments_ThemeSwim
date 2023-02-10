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
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.ThemeSwim.Any())
                {
                    return;   // DB has been seeded
                }

                context.ThemeSwim.AddRange(
                    new ThemeSwim
                    {
                        EventName = "When Harry Met Sally",
                        BookingDate = DateTime.Parse("1989-2-12"),
                        Competition = "Romantic Comedy",
                        PoolName = "A"
                        EntryPrice = 7.99M
                    },

                    new ThemeSwim
                    {
                        EventName = "When Harry Met Sally",
                        BookingDate = DateTime.Parse("1989-2-12"),
                        Competition = "Romantic Comedy",
                        PoolName = "A"
                        EntryPrice = 7.99M
                    },

                    new ThemeSwim
                    {
                        EventName = "When Harry Met Sally",
                        BookingDate = DateTime.Parse("1989-2-12"),
                        Competition = "Romantic Comedy",
                        PoolName = "A"
                        EntryPrice = 7.99M
                    },

                    new ThemeSwim
                    {
                        EventName = "When Harry Met Sally",
                        BookingDate = DateTime.Parse("1989-2-12"),
                        Competition = "Romantic Comedy",
                        PoolName = "A"
                        EntryPrice = 7.99M
                    },

                    new ThemeSwim
                    {
                        EventName = "When Harry Met Sally",
                        BookingDate = DateTime.Parse("1989-2-12"),
                        Competition = "Romantic Comedy",
                        PoolName = "A"
                        EntryPrice = 7.99M
                    },
                   
                );
                context.SaveChanges();
            }
        }
    }
}