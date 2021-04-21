﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPLR_one
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
