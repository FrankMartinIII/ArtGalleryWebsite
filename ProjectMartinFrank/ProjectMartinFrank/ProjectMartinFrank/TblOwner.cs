using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblOwner
    {
        public TblOwner()
        {
            TblPets = new HashSet<TblPet>();
        }

        public int OwnerId { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerTown { get; set; }
        public string OwnerState { get; set; }
        public string OwnerPhoneNumber { get; set; }

        public virtual ICollection<TblPet> TblPets { get; set; }
    }
}
