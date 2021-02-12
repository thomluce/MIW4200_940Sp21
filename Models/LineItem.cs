using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIW4200_940.Models
{
    public class LineItem
    {
        public int lineitemID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int productID { get; set; }
        public virtual Product product { get; set; }
        public int ordersID { get; set; }
        public virtual Orders orders { get; set; }

    }
}