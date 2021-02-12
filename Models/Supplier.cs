using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIW4200_940.Models
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public string supplierName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public ICollection<Product> product { get; set; }
    }
}