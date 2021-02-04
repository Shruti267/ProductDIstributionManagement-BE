using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class Representer
    {
        public int RepresenterId { get; set; }
        public string RepresenterName { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
