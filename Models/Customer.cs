using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIW4200_940.Models
{
    public class Customer
    {
        public int customerID {get; set;}

        [Display(Name ="First Name")]  
        [Required(ErrorMessage = "Customer first name is required")]
        [RegularExpression("^([a-zA-Z']+)$", ErrorMessage ="Names must be composed of only letters and, optionally, a sigle quote")]
        public string firstName { get; set; }

        [Display(Name ="Customer Last Name")]
        [Required]
        [StringLength(30,  ErrorMessage = "Name must be 30 characters or less")]
        public string lastName { get; set; }

        [DataType(DataType.EmailAddress )]
        public string email { get; set; }
        public string phone { get; set; }

        [DisplayFormat (DataFormatString ="{0:d}",ApplyFormatInEditMode = true)]
        public DateTime customerSince { get; set; }

        [Display(Name = "Customer Name")]
        public string fullName {
            get 
            {
                return lastName + ", " + firstName;
            }  
        }
        public ICollection<Orders>  orders { get; set; }


    }
}