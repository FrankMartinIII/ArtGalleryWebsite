using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblViolation
    {
        public TblViolation()
        {
            TblTickets = new HashSet<TblTicket>();
        }

        public int ViolationId { get; set; }
        public string Violation { get; set; }
        public int? Fine { get; set; }

        public virtual ICollection<TblTicket> TblTickets { get; set; }
    }
}
