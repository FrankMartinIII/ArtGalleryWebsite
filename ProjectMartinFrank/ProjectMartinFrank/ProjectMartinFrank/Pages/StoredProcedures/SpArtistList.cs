using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProjectMartinFrank
{
    public class SpArtistList
    {
        public int artistID { get; set; }
        [Display(Name = "First Name")]
        public string artistFName { get; set; }
        [Display(Name = "Last Name")]
        public string artistLName { get; set; }
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy}")]
        public DateTime? artistDOB { get; set; }
        [Display(Name = "Email")]
        public string artistEmail { get; set; }
        [Display(Name = "Amount of Art Uploaded")]
        public int AmountArtUploaded { get; set; }
    }
}
