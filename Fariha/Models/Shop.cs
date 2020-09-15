using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Fariha.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Services { get; set; }
    }

    public class ShopDBContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
    }
}