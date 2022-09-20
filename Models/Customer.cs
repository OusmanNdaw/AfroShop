using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfroShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }    
        public string Email { get; set; }   
        public string PhoneNumber { get; set; } 

        public ICollection<Order> Orders { get; set; }
    }
}
