using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class CoffeeShop
    {
        public CoffeeShop()
        {
            Cashiers = new HashSet<Cashier>();
            Orders = new HashSet<Order>();
        }

        public int CoffeeShopId { get; set; }
        public int OwnerId { get; set; }
        public string Address { get; set; }

        public virtual Owner Owner { get; set; }
        public virtual ICollection<Cashier> Cashiers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
