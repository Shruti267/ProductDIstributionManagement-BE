using System;
using System.Collections.Generic;

namespace SupplyChainManagement.Models
{
    public partial class Client
    {
        public Client()
        {
            Order = new HashSet<Order>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        public string Gstno { get; set; }
        public decimal? Mobile { get; set; }
        public decimal? LandLine { get; set; }
        public string Email { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
