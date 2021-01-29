using System;
using System.Collections.Generic;

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
