using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hardware.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<HardwareLines> Products
        {
            get { return context.Products; }
        }
    }
}