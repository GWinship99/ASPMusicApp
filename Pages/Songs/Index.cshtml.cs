using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPMusicApp.Data;
using ASPMusicApp.Models;

namespace ASPMusicApp.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly ASPMusicApp.Data.ASPMusicAppContext _context;

        public IndexModel(ASPMusicApp.Data.ASPMusicAppContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Song = await _context.Song.ToListAsync();
        }
    }
}
