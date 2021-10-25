using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblFaculty
    {
        public TblFaculty()
        {
            TblIncidents = new HashSet<TblIncident>();
        }

        public int FacultyId { get; set; }
        public string FacName { get; set; }
        public string Dept { get; set; }
        public string FacGender { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Salary { get; set; }
        public int? CarId { get; set; }

        public virtual TblCar Car { get; set; }
        public virtual ICollection<TblIncident> TblIncidents { get; set; }
    }
}
