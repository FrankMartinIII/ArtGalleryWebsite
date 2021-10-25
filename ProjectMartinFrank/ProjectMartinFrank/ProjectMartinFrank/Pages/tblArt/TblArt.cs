using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblArt
    {
        public int ArtId { get; set; }
        public string ArtTitle { get; set; }
        public DateTime? ArtDate { get; set; }
        public string ArtType { get; set; }
        public int? ArtPrice { get; set; }
        public int? ArtistId { get; set; }
        public string ArtImg { get; set; }

        public virtual TblArtist Artist { get; set; }
    }
}
