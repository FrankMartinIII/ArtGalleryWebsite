using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectMartinFrank
{
    public class SpUserFavArt
    {
        [Display(Name = "Type of Art")]
        public string userFavTypeArt { get; set; }
        [Display(Name = "Count of Users")]
        public int CountFavoriteArtTypeUsers { get; set; }
    }
}
