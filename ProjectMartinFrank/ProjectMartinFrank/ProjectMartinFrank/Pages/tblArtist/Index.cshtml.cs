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
    public class IndexModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public IndexModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IList<TblArtist> TblArtist { get;set; }

        public async Task OnGetAsync()
        {
            TblArtist = await _context.TblArtists.ToListAsync();
        }
    }
}
