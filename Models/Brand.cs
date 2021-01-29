using System;
using System.Collections.Generic;

namespace SupplyChainManagement.Models
{
    public partial class Brand
    {
        public Brand()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<OrderedProduct> OrderedProduct { get; set; }
    }
}
