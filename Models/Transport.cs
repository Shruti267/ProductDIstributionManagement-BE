using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class Transport
    {
        public Transport()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
        }

        public int TransportId { get; set; }
        public string TruckNumber { get; set; }
        public string TransporterName { get; set; }
        public DateTime TruckDepartureDate { get; set; }
        public decimal? TruckDriverNumber { get; set; }
        public decimal TotalWeight { get; set; }

        public virtual ICollection<OrderedProduct> OrderedProduct { get; set; }
    }
}
