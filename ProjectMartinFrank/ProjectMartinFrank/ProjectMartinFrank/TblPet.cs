using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblPet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetBreed { get; set; }
        public string PetSex { get; set; }
        public DateTime? PetDob { get; set; }
        public int? PetPrice { get; set; }
        public string PetNotes { get; set; }
        public int? OwnerId { get; set; }

        public virtual TblOwner Owner { get; set; }
    }
}
