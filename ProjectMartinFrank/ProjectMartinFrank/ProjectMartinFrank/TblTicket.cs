using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblTicket
    {
        public int TicketId { get; set; }
        public DateTime? TicketDate { get; set; }
        public int? ViolationId { get; set; }
        public int? PoliceId { get; set; }
        public int? DriverId { get; set; }

        public virtual TblDriver Driver { get; set; }
        public virtual TblPolice Police { get; set; }
        public virtual TblViolation Violation { get; set; }
    }
}
