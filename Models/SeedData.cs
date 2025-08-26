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
            }
        }
    }
}
