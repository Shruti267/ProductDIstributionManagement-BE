using System;
using System.Collections.Generic;

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
