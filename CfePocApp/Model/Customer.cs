using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CfePocApp.Model
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public OrderStatus Status { get; set; }
    }
}
