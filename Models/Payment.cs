using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
