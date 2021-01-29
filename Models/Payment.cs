using System;
using System.Collections.Generic;

namespace SupplyChainManagement.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public bool PaymentStatus { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentDetails { get; set; }
        public DateTime PaymentDate { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
