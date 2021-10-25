using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class VwArtandArtist
    {
        [Display(Name = "Artist's First Name")]
        public string ArtistFname { get; set; }
        [Display(Name = "Artist's Last Name")]
        public string ArtistLname { get; set; }
        [Display(Name = "Art Title")]
        public string ArtTitle { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy}")]
        [Display(Name = "Date of Creation")]
        public DateTime? ArtDate { get; set; }
        [Display(Name = "Medium")]
        public string ArtType { get; set; }
        [DisplayFormat(DataFormatString = "${0:#,0}")]
        [Display(Name = "Price")]
        public int? ArtPrice { get; set; }
        [Display(Name = "Image")]
        public string ArtImg { get; set; }
    }
}
