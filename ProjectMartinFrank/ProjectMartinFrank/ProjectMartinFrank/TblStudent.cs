using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblStudent
    {
        public TblStudent()
        {
            TblIncidents = new HashSet<TblIncident>();
        }

        public int StudentId { get; set; }
        public string SName { get; set; }
        public string SlName { get; set; }
        public DateTime? Dob { get; set; }
        public string Sgender { get; set; }
        public string Major { get; set; }
        public int? CarId { get; set; }

        public virtual TblCar Car { get; set; }
        public virtual ICollection<TblIncident> TblIncidents { get; set; }
    }
}
