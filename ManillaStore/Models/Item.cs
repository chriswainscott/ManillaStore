using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManillaStore.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }
        public string  ItemDescription { get; set; }
        public decimal ItemAmount { get; set; }
        public int UpcCode { get; set; }


        public virtual ICollection<Transaction> Transaction { get; set; }
      
    }
}