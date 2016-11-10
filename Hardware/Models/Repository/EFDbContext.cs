using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Hardware.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<HardwareLines> Products { get; set; }
    }
}