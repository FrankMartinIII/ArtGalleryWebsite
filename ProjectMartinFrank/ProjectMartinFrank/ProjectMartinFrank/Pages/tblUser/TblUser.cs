using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        public string UserFname { get; set; }
        [Display(Name = "Last Name")]
        public string UserLname { get; set; }
        [DisplayFormat(DataFormatString ="{0: dd/mm/yyyy}")]
        [Display(Name = "Date of Birth")]
        public DateTime? UserDob { get; set; }
        [Display(Name = "Email")]
        public string UserEmail { get; set; }
        [Display(Name = "Favorite Type of Art")]
        public string UserFavTypeArt { get; set; }
    }
}
