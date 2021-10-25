using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ProjectMartinFrank.Pages.StoredProcedures
{
    public class ArtistListModel : PageModel
    {
        private readonly ProjectMartinFrank.FMartiniii1Context _context;

        public ArtistListModel(ProjectMartinFrank.FMartiniii1Context context)
        {
            _context = context;
        }

        public IList<SpArtistList> spArtistLists { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                var lastNameSQLParam = new Microsoft.Data.SqlClient.SqlParameter("@LastName", "");
                spArtistLists = await _context.SpArtistLists.FromSqlRaw("Exec SpArtistList @LastName={0}", lastNameSQLParam).ToListAsync();
            }
            catch(Exception)
            {
                Console.WriteLine("FAILED");
            }
        }

        public async Task OnPostAsync()
        {
            try
            {
                string lname = HttpContext.Request.Form["lname"];
                var lastNameSQLParam = new Microsoft.Data.SqlClient.SqlParameter("@LastName", lname);
                spArtistLists = await _context.SpArtistLists.FromSqlRaw("Exec SpArtistList @LastName={0}", lastNameSQLParam).ToListAsync();
            }
            catch(Exception)
            {

            }
        }
    }
}
