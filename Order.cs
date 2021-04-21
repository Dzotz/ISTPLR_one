using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class Order
    {
        public Order()
        {
            Positions = new HashSet<Position>();
        }

        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int CashierId { get; set; }
        public int CoffeeShopId { get; set; }
        public int? BonusId { get; set; }

        public virtual Client Bonus { get; set; }
        public virtual Cashier Cashier { get; set; }
        public virtual CoffeeShop CoffeeShop { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
