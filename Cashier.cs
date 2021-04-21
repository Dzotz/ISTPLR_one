using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class Cashier
    {
        public Cashier()
        {
            Orders = new HashSet<Order>();
        }

        public int CashierId { get; set; }
        public int CoffeeShopId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string PhoneNumber { get; set; }

        public virtual CoffeeShop CoffeeShop { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
