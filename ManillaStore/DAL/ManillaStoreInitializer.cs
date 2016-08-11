using ManillaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManillaStore.DAL
{
    public class ManillaStoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ManillaStoreContext>
    {
        protected override void Seed(ManillaStoreContext context)
        {
            var customer = new List<Customer>
            {
            new Customer{FirstName="Cash",LastName="Customer",},
            new Customer{FirstName="Chris",LastName="Wainscott",},
            new Customer{FirstName="Jennifer",LastName="Wainscott",},
            new Customer{FirstName="Sharon",LastName="Fansler",},
            new Customer{FirstName="Dorreta",LastName="Gahimer",},
            new Customer{FirstName="Rose",LastName="Callahan",},
            new Customer{FirstName="Kim",LastName="Hughes",},
            new Customer{FirstName="Kathy",LastName="Hill",},
            new Customer{FirstName="Phil",LastName="Toll",},
            new Customer{FirstName="Doug",LastName="Smalltown",}
            };

            customer.ForEach(s => context.Customer.Add(s));
            context.SaveChanges();
            var item = new List<Item>
            {
            new Item{ItemID=1,ItemDescription="Camel Wide Men Box",  ItemAmount=6.49m,},
            new Item{ItemID=2,ItemDescription="Swish Swt Little Cigar", ItemAmount=5.75m,},
            new Item{ItemID=3,ItemDescription="Red Man Select",  ItemAmount=3.98m,},
            new Item{ItemID=4,ItemDescription="Bic Tatoo Lighter",  ItemAmount=1.19m,},
            new Item{ItemID=5,ItemDescription="Q-tips Cotton Swab Purse",  ItemAmount=.99m,},
            new Item{ItemID=6,ItemDescription="Juicy Fruit",  ItemAmount=1.25m,},
            new Item{ItemID=7,ItemDescription="M&M Plain",  ItemAmount=1.19m,},
            new Item{ItemID=8,ItemDescription="Pringles Cheddar Cheese", ItemAmount=1.99m,},
            new Item{ItemID=9,ItemDescription="Rays Reg Chip PP 1.19", ItemAmount=1.19m,},
            new Item{ItemID=10,ItemDescription="Buds Best Pecan Choc Chip",  ItemAmount=1.89m,},
            new Item{ItemID=11,ItemDescription="Crisco Oil",  ItemAmount=4.99m,},
            new Item{ItemID=12,ItemDescription="Bisquick Mix", ItemAmount=2.49m, }
           
            };
            item.ForEach(s => context.Item.Add(s));
            context.SaveChanges();
            var transaction = new List<Transaction>
            {
            new Transaction{CustomerID=1,ItemID=1,},
            new Transaction{CustomerID=1,ItemID=2,},
            new Transaction{CustomerID=1,ItemID=3,},
            new Transaction{CustomerID=2,ItemID=4,},
            new Transaction{CustomerID=2,ItemID=5,},
            new Transaction{CustomerID=2,ItemID=6,},
            new Transaction{CustomerID=3,ItemID=7,},
            new Transaction{CustomerID=4,ItemID=8,},
            new Transaction{CustomerID=4,ItemID=9,},
            new Transaction{CustomerID=5,ItemID=10,},
            new Transaction{CustomerID=6,ItemID=11,},
            new Transaction{CustomerID=7,ItemID=12,},
                                         

            };  
            transaction.ForEach(s => context.Transaction.Add(s));
            context.SaveChanges();
        }
    }
}