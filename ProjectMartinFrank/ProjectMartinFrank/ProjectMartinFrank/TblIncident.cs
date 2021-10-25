using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblIncident
    {
        public int IncidentId { get; set; }
        public DateTime IncidentDate { get; set; }
        public int? StudentId { get; set; }
        public int? FacultyId { get; set; }
        public int PId { get; set; }
        public int? CarId { get; set; }
        public string IncidentDesc { get; set; }

        public virtual TblCar Car { get; set; }
        public virtual TblFaculty Faculty { get; set; }
        public virtual TblPublicSafety PIdNavigation { get; set; }
        public virtual TblStudent Student { get; set; }
    }
}
