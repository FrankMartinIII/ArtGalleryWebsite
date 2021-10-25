using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectMartinFrank;

namespace ProjectMartinFrank.Pages.tblArtist
{
    public class EditModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public EditModel(ProjectMartinFrank.FMartiniii1Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblArtist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblArtistExists(TblArtist.ArtistId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TblArtistExists(int id)
        {
            return _context.TblArtists.Any(e => e.ArtistId == id);
        }
    }
}
