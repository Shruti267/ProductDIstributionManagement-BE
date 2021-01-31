using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<OrderedProduct> OrderedProduct { get; set; }
    }
}
