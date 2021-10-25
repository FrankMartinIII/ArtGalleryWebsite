using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblPolice
    {
        public TblPolice()
        {
            TblTickets = new HashSet<TblTicket>();
        }

        public int PoliceId { get; set; }
        public string Pname { get; set; }

        public virtual ICollection<TblTicket> TblTickets { get; set; }
    }
}
