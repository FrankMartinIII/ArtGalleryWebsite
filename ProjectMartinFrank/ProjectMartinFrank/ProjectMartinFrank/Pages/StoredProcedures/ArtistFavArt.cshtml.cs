using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ProjectMartinFrank.Pages.StoredProcedures
{
    public class ArtistFavArtModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public ArtistFavArtModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IList<SpArtistFavArt> spArtistFavArts { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                spArtistFavArts = await _context.SpArtistFavArts.FromSqlRaw("Exec SpArtistFavArt").ToListAsync();
            }
            catch(Exception)
            {

            }
        }

        public async Task OnPostAsync()
        {
            spArtistFavArts = await _context.SpArtistFavArts.FromSqlRaw("Exec SpArtistFavArt").ToListAsync();
        }
    }
}
