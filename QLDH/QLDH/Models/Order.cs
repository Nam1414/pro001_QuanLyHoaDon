using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH.Models
{
    public class Order:IOrder
    {
        public int OrderId { get; set; }
        public string? ProductType { get; set; }
        public string? OrderMode { get; set; } // Legacy | Modern
    }
}

