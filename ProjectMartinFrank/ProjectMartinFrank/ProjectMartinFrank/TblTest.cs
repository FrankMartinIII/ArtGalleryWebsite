using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class TblTest
    {
        public int ColorimgId { get; set; }
        public string Randomtext { get; set; }
        public string Imgvarname { get; set; }
        public int? CarId { get; set; }

        public virtual TblCar Car { get; set; }
    }
}
