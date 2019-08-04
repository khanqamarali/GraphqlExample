using System;
using System.Collections.Generic;


namespace graphqllesssion1.Models
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Purchase> Purchases { get; set; }
    }

    public class Purchase
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
    }
}
