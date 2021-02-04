using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class City
    {
        public City()
        {
            Client = new HashSet<Client>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
