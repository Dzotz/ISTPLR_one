using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int FavoriteProductId { get; set; }

        public virtual Product FavoriteProduct { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
