using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManillaStore.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime PurchaseDate { get; set; }



        public virtual ICollection<Transaction> Transaction { get; set; }
      

    }
}