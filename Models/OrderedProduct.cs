using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class OrderedProduct
    {
        public int OrderedProductId { get; set; }
        public int SupplierId { get; set; }
        public int BrandId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int PricePerUnit { get; set; }
        public int? PackingCharge { get; set; }
        public int? Discount { get; set; }
        public int TotalPriceToBePaid { get; set; }
        public int OrderId { get; set; }
        public int? TransportId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Transport Transport { get; set; }
    }
}
