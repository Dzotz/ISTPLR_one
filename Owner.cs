using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class Owner
    {
        public Owner()
        {
            CoffeeShops = new HashSet<CoffeeShop>();
        }

        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<CoffeeShop> CoffeeShops { get; set; }
    }
}
