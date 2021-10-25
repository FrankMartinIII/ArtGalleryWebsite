using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectMartinFrank;

namespace ProjectMartinFrank.Pages.tblArtist
{
    public class DetailsModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public DetailsModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public TblArtist TblArtist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblArtist = await _context.TblArtists.FirstOrDefaultAsync(m => m.ArtistId == id);

            if (TblArtist == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
