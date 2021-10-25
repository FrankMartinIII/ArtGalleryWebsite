using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblPublicSafety
    {
        public TblPublicSafety()
        {
            TblIncidents = new HashSet<TblIncident>();
        }

        public int PId { get; set; }
        public string PName { get; set; }
        public string PGender { get; set; }
        public string PBadgeNo { get; set; }

        public virtual ICollection<TblIncident> TblIncidents { get; set; }
    }
}
