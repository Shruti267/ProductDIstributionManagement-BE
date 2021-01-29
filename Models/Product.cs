using System;
using System.Collections.Generic;

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
