using System;
using System.Collections.Generic;

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
