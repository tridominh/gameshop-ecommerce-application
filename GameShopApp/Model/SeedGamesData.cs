using GameShopApp.Data;
using GameShopApp.Model;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models;

public static class SeedGamesData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new GameShopAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<GameShopAppContext>>()))
        {
            if (context == null || context.Game == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }

            context.Game.AddRange(
                new Game
                {
                    Name = "League of Legends",
                    ReleaseDate = DateTime.Parse("2011-2-12"),
                    Genre = "MOBA",
                    Price = 7.99M,
                    Rating = "E"
                },

                new Game
                {
                    Name = "DOTA 2",
                    ReleaseDate = DateTime.Parse("2012-3-13"),
                    Genre = "MOBA",
                    Price = 8.99M,
                    Rating = "PG-18"
                },

                new Game
                {
                    Name = "Fortnite",
                    ReleaseDate = DateTime.Parse("2019-2-23"),
                    Genre = "Battle Royale",
                    Price = 9.99M,
                    Rating= "E"
                },

                new Game
                {
                    Name = "Mortal Kombat 1",
                    ReleaseDate = DateTime.Parse("2023-4-15"),
                    Genre = "Fighting",
                    Price = 3.99M,
                    Rating= "R"
                }
            );
            context.SaveChanges();
        }
    }
}