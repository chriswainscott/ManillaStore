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
            new Customer{FirstName="Cash",LastName="Customer",PurchaseDate=DateTime.Parse("2016-05-04"),},
            new Customer{FirstName="Chris",LastName="Wainscott",PurchaseDate=DateTime.Parse("2016-05-04"),},
            new Customer{FirstName="Jennifer",LastName="Wainscott",PurchaseDate=DateTime.Parse("2016-05-04"),},
            new Customer{FirstName="Sharon",LastName="Fansler",PurchaseDate=DateTime.Parse("2016-05-05"),},
            new Customer{FirstName="Dorreta",LastName="Gahimer",PurchaseDate=DateTime.Parse("2016-05-05"),},
            new Customer{FirstName="Rose",LastName="Callahan",PurchaseDate=DateTime.Parse("2016-05-05"),},
            new Customer{FirstName="Kim",LastName="Hughes",PurchaseDate=DateTime.Parse("2016-05-05"),},
            new Customer{FirstName="Kathy",LastName="Hill",PurchaseDate=DateTime.Parse("2016-05-05"),},
            new Customer{FirstName="Phil",LastName="Toll",PurchaseDate=DateTime.Parse("2016-05-06"),},
            new Customer{FirstName="Doug",LastName="Smalltown",PurchaseDate=DateTime.Parse("2005-05-06"),}
            };

            customer.ForEach(s => context.Customer.Add(s));
            context.SaveChanges();
            var item = new List<Item>
            {
            new Item{ItemID=1,ItemDescription="Camel Wide Men Box",  ItemAmount=6.49m, UpcCode=4937280,},
            new Item{ItemID=2,ItemDescription="Swish Swt Little Cigar", ItemAmount=5.75m, UpcCode=5004452,},
            new Item{ItemID=3,ItemDescription="Red Man Select",  ItemAmount=3.98m, UpcCode=5017231,},
            new Item{ItemID=4,ItemDescription="Bic Tatoo Lighter",  ItemAmount=1.19m, UpcCode=3959905,},
            new Item{ItemID=5,ItemDescription="Q-tips Cotton Swab Purse",  ItemAmount=.99m, UpcCode=2468510,},
            new Item{ItemID=6,ItemDescription="Juicy Fruit",  ItemAmount=1.25m, UpcCode=1566249,},
            new Item{ItemID=7,ItemDescription="M&M Plain",  ItemAmount=1.19m, UpcCode=1526052,},
            new Item{ItemID=8,ItemDescription="Pringles Cheddar Cheese", ItemAmount=1.99m, UpcCode=1801208,},
            new Item{ItemID=9,ItemDescription="Rays Reg Chip PP 1.19", ItemAmount=1.19m, UpcCode=1680396,},
            new Item{ItemID=10,ItemDescription="Buds Best Pecan Choc Chip",  ItemAmount=1.89m, UpcCode=1716190,},
            new Item{ItemID=11,ItemDescription="Crisco Oil",  ItemAmount=4.99m, UpcCode=1077742,},
            new Item{ItemID=12,ItemDescription="Bisquick Mix", ItemAmount=2.49m, UpcCode=1111301,}
           
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