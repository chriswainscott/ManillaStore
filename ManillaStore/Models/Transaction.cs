using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManillaStore.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int ItemID { get; set; }
        public int CustomerID { get; set; }
        

        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}