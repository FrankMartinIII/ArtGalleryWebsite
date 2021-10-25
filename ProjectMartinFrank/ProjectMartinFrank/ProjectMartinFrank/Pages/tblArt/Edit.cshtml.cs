using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectMartinFrank;

namespace ProjectMartinFrank.Pages.tblArt
{
    public class EditModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public EditModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TblArt TblArt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblArt = await _context.TblArts
                .Include(t => t.Artist).FirstOrDefaultAsync(m => m.ArtId == id);

            if (TblArt == null)
            {
                return NotFound();
            }
           ViewData["ArtistId"] = new SelectList(_context.TblArtists, "ArtistId", "ArtistId");
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

            _context.Attach(TblArt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblArtExists(TblArt.ArtId))
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

        private bool TblArtExists(int id)
        {
            return _context.TblArts.Any(e => e.ArtId == id);
        }
    }
}
