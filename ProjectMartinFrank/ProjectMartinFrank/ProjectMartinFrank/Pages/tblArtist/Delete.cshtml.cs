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
    public class DeleteModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public DeleteModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblArtist = await _context.TblArtists.FindAsync(id);

            if (TblArtist != null)
            {
                _context.TblArtists.Remove(TblArtist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
