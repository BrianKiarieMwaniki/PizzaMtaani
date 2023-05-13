using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMtaani.CoreBusiness.Models
{
    public class Topping
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Size { get; set; }
    }
}
