using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class Product
    {
        public Product()
        {
            Clients = new HashSet<Client>();
            Positions = new HashSet<Position>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
