using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBakeries.Models
{
    public class BakeryContext : DbContext
    {
        public BakeryContext() : base("keydbBakery"){ }
        public DbSet<Bakery> Bakeries { get; set; }
        public DbSet<Cupcake> Cupcakes { get; set; }
    }
}