using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaPro3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal price { get; set; }
        public int      Qty { get; set; }
        public  DateTime creationDate { get; set; }

    }
}
