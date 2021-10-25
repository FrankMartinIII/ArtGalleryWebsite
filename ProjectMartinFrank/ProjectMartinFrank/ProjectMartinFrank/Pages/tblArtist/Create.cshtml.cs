using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectMartinFrank;

namespace ProjectMartinFrank.Pages.tblArtist
{
    public class CreateModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public CreateModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TblArtist TblArtist { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblArtists.Add(TblArtist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
