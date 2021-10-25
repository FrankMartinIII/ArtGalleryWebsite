using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectMartinFrank
{
    public class SpArtistFavArt
    {
        [Display(Name = "Type of Art")]
        public string artistFavTypeArt { get; set; }
        [Display(Name = "Count of Artists")]
        public int CountFavoriteArtTypeArtists { get; set; }
    }
}
