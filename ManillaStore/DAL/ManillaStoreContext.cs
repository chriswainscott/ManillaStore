using ManillaStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ManillaStore.DAL
{
    public class ManillaStoreContext: DbContext
    {

        public ManillaStoreContext() : base("ManillaStoreContext")
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
