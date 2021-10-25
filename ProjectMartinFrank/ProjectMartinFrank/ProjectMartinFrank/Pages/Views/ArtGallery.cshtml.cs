using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ProjectMartinFrank.Pages.Views
{
    public class ArtGalleryModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public ArtGalleryModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IList<VwArtandArtist> VwArtandArtist { get; set; }

        public async Task OnGetAsync()
        {
            VwArtandArtist = await _context.VwArtandArtists.ToListAsync();
        }
    }
}
