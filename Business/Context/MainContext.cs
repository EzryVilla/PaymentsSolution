using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Business.EntityFramework
{
    // This class doesn't have a use, it's just for demo purpose.
    public class MainContext : DbContext
    {
        public MainContext() : base()
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
