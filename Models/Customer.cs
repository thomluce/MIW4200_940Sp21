﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIW4200_940.Models
{
    public class Customer
    {
        public int customerID {get; set;}
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        public string fullName {
            get 
            {
                return lastName + ", " + firstName;
            }  
        }
        public ICollection<Orders>  orders { get; set; }


    }
}