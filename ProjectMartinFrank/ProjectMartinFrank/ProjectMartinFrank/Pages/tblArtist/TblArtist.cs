using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblArtist
    {
        public TblArtist()
        {
            TblArts = new HashSet<TblArt>();
        }

        public int ArtistId { get; set; }
        public string ArtistFname { get; set; }
        public string ArtistLname { get; set; }
        public DateTime? ArtistDob { get; set; }
        public string ArtistEmail { get; set; }
        public string ArtistFavTypeArt { get; set; }

        public virtual ICollection<TblArt> TblArts { get; set; }
    }
}
