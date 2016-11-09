﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hardware.Models
{
    public class Hardware
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}