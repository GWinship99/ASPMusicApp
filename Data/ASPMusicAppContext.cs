using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPMusicApp.Models;

namespace ASPMusicApp.Data
{
    public class ASPMusicAppContext : DbContext
    {
        public ASPMusicAppContext (DbContextOptions<ASPMusicAppContext> options)
            : base(options)
        {
        }

        public DbSet<ASPMusicApp.Models.Song> Song { get; set; } = default!;
    }
}
