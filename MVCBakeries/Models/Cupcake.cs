using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBakeries.Models
{
    public class Cupcake
    {
        public int CupcakeId { get; set; }
        public string CupcakeType { get; set; }
        public string Description { get; set; }
        public bool GlutenFree { get; set; }
        public decimal Price { get; set; }
        public int BakeryId { get; set; }
    }
}