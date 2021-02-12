﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIW4200_940.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public ICollection<LineItem> lineItem { get; set; }
        public int supplierID { get; set; }
        public virtual Supplier supplier { get; set; }
    }
}