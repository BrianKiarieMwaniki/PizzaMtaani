using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMtaani.CoreBusiness.Entities;

namespace PizzaMtaani.CoreBusiness.Models
{
    public class Order
    {
        public Order()
        {
            LineItems = new List<OrderLineItem>();
        }
        public int? OrderId { get; set; }
        public decimal VAT { get => CalculateVAT(); }
        public decimal SubTotal { get => CalculateSubTotal();}
        public decimal Total { get => (VAT + SubTotal);}
        public List<OrderLineItem> LineItems { get; set; }
        public string? UniqueId { get; set; }

        public void AddPizzaToOrder(Guid pizzaId,Pizza pizza, int qty, decimal price)
        {
            var item = LineItems.FirstOrDefault(p => p.PizzaId == pizzaId);

            if(item != null)
            {
                item.Quantity += qty;
                return;
            }

            LineItems.Add(new OrderLineItem { PizzaId = pizzaId,Pizza = pizza,Quantity = qty, Price = price });

        }


        public void RemovePizza(Guid pizzaId)
        {
            var item = LineItems.First(p => p.PizzaId == pizzaId);

            if (item == null) return;
            
            LineItems.Remove(item);
        }


        private decimal CalculateSubTotal()
        {
            if(LineItems.Count == 0) return 0;

            decimal subtotal = 0;

            LineItems.ForEach(i => { subtotal += i.Quantity * i.Price; });

            return subtotal;
        }

        private decimal CalculateVAT()
        {
            if (SubTotal > 0) return (decimal)(0.16 * Convert.ToDouble(SubTotal));

            return 0;
        }
    }


}
