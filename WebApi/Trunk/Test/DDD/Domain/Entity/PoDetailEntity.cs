﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DDD.Domain.Entity
{
    public class PoDetailEntity
    {
        public string Ponum { get; set; }

        public string ItemNum { get; set; }

        public string Lot { get; set; }

        public decimal Qty { get; set; }

        public String Uom { get; set; }

        public decimal Uprice { get; set; }

        public decimal Amount { get { return Qty * Uprice; }  }
    }
}
