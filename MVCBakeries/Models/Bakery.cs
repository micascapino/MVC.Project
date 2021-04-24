using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBakeries.Models
{
    public class Bakery
    {
        public int BakeryId { get; set; }
        [Required]
        public string BakeryName { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public List<Cupcake> Cupcakes { get; set; }
    }
}