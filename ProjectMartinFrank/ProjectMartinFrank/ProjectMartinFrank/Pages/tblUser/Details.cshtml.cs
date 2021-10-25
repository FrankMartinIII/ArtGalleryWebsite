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
    public class DetailsModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public DetailsModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

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
    }
}
