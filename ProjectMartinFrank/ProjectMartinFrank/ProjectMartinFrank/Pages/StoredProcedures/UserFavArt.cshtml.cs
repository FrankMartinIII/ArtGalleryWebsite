using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ProjectMartinFrank.Pages.StoredProcedures
{
    public class UserFavArtModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public UserFavArtModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IList<SpUserFavArt> spUserFavArts { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                spUserFavArts = await _context.SpUserFavArts.FromSqlRaw("Exec SpUserFavArt").ToListAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task OnPostAsync()
        {
            spUserFavArts = await _context.SpUserFavArts.FromSqlRaw("Exec SpUserFavArt").ToListAsync();
        }
    }
}
