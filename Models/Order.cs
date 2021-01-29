using System;
using System.Collections.Generic;

namespace SupplyChainManagement.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
            Payment = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ClientId { get; set; }
        public string Remarks { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProduct { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
