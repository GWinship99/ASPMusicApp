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
    public class DetailsModel : PageModel
    {
        private readonly ASPMusicApp.Data.ASPMusicAppContext _context;

        public DetailsModel(ASPMusicApp.Data.ASPMusicAppContext context)
        {
            _context = context;
        }

        public Song Song { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }
            else
            {
                Song = song;
            }
            return Page();
        }
    }
}
