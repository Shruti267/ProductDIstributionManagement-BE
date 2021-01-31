using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
            Representer = new HashSet<Representer>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public virtual ICollection<OrderedProduct> OrderedProduct { get; set; }
        public virtual ICollection<Representer> Representer { get; set; }
    }
}
