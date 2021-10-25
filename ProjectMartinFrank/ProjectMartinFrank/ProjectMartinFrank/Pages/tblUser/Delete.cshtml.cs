using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectMartinFrank;

namespace ProjectMartinFrank.Pages.tblUser
{
    public class DeleteModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public DeleteModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TblUser TblUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblUser = await _context.TblUsers.FirstOrDefaultAsync(m => m.UserId == id);

            if (TblUser == null)
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

            TblUser = await _context.TblUsers.FindAsync(id);

            if (TblUser != null)
            {
                _context.TblUsers.Remove(TblUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
