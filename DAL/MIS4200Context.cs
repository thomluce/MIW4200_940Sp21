using MIW4200_940.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIW4200_940.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }

        public DbSet<Customer>  customer { get; set; }
        public DbSet<Orders> orders  { get; set; }
        public DbSet<LineItem> lineItem { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Supplier> supplier { get; set; }
        public DbSet<Profile> profile { get; set; }
    }

}