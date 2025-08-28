using ASPMusicApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ASPMusicApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ASPMusicAppContext(serviceProvider.GetRequiredService<DbContextOptions<ASPMusicAppContext>>()))
            {
                if (context == null || context.Song == null)
                {
                    throw new ArgumentNullException("Null ASPMusicAppContext");
                }

                //Look for songs
                if (context.Song.Any()) {
                    return;
                }

                context.Song.AddRange(
                    new Song
                    {
                        Title = "Fight Song",
                        ReleaseDate = DateTime.Parse("2015-2-19"),
                        Genre = "Pop Rock",
                        Artist = "Rachel Platten",
                        Rating = "Good"
                    },

                    new Song
                    {
                        Title = "Complicated",
                        ReleaseDate = DateTime.Parse("2002-3-11"),
                        Genre = "Pop Rock",
                        Artist = "Avril Lavigne",
                        Rating = "Good"
                    },

                    new Song
                    {
                        Title = "Judas",
                        ReleaseDate = DateTime.Parse("2017-5-5"),
                        Genre = "Metal",
                        Artist = "Fozzy",
                        Rating = "OK"
                    },
                    new Song
                    {
                        Title = "Black Swan",
                        ReleaseDate = DateTime.Parse("2020-1-20"),
                        Genre = "Trap",
                        Artist = "BTS",
                        Rating = "Acclaimed"
                    }

                    );
                    context.SaveChanges();
            }
        }
    }
}
