using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblDriver
    {
        public TblDriver()
        {
            TblTickets = new HashSet<TblTicket>();
        }

        public int DriverId { get; set; }
        public string Dname { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Dstate { get; set; }
        public int? Zip { get; set; }

        public virtual ICollection<TblTicket> TblTickets { get; set; }
    }
}
