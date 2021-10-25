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
    public class IndexModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public IndexModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IList<TblArt> TblArt { get;set; }

        public async Task OnGetAsync()
        {
            TblArt = await _context.TblArts
                .Include(t => t.Artist).ToListAsync();
        }
    }
}
