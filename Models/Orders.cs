using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIW4200_940.Models
{
    public class Orders
    {
        public int ordersID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
        public ICollection<LineItem> lineItem { get; set; }
    }
}