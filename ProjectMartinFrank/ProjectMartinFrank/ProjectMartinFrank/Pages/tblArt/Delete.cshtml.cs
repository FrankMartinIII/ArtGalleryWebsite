using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectMartinFrank;

namespace ProjectMartinFrank.Pages.tblArt
{
    public class DeleteModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public DeleteModel(ProjectMartinFrank.FMartiniii1Context context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblArt = await _context.TblArts.FindAsync(id);

            if (TblArt != null)
            {
                _context.TblArts.Remove(TblArt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
