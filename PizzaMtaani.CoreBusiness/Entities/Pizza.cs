using System.ComponentModel.DataAnnotations;
using PizzaMtaani.CoreBusiness.Models;

namespace PizzaMtaani.CoreBusiness.Entities
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string? Name { get => ToString(); }
        public string? Description { get; set; }
        public PizzaSize Size { get; set; } = PizzaSize.Small;
        public List<Topping>? Toppings { get; set; }
        public decimal Price { get => GetPrice(Size); }
        public decimal TotalNetPrice { get => CalculateNetPrice(); }
        private decimal CalculateNetPrice()
        {
            if (Toppings is null) return Price;

            decimal netPrice = Toppings.Sum(t => t.Price * t.Quantity);
            netPrice += Price;

            return Math.Round(netPrice, 2);
        }

        public decimal GetPrice(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.Small:
                    return 1200;
                case PizzaSize.Medium:
                    return 1400;
                case PizzaSize.Large:
                    return 1600;

                default: return 0;
            }
        }

        public void AddTopping(PizzaTopping pizzaTopping)
        {          
            var toppingAlreadyAdded = Toppings?.Where(t => t.Id.Equals(pizzaTopping.Id) && t.Size.Equals(pizzaTopping.SelectedSize)).FirstOrDefault();

            if (toppingAlreadyAdded != null)
            {
                int index = (int)Toppings?.IndexOf(toppingAlreadyAdded);
                Toppings[index].Quantity += 1;               
            }
            else
            {
                var topping = new Topping
                {
                    Id = pizzaTopping.Id,
                    Name = pizzaTopping.Name,
                    Quantity = 1,
                    Size = pizzaTopping.SelectedSize,
                    Price = pizzaTopping.SelectedPrice
                };
                Toppings?.Add(topping);
            }
        }

        public void UpdateToppingQuantity(Guid id,string size, string operation = "add")
        {
            var toppingToUpdate = Toppings?.Where(t => t.Id.Equals(id) && t.Size.Equals(size)).FirstOrDefault();

            if (toppingToUpdate is null) return;

            if(operation.Equals("add"))
            {
                toppingToUpdate.Quantity += 1;
            }

            if(operation.Equals("subtract"))
            {
                if (toppingToUpdate.Quantity == 0) return;

                toppingToUpdate.Quantity -= 1;
            }
        }

        public override string ToString()
        {
            var distinctToppings = Toppings?.Distinct(new ToppingIdComparer()).ToList();

            var str = $"1 {Size}, {distinctToppings?.Count} Toppping Pizza - ";

            if (Toppings is null) return str;

            foreach (var topping in distinctToppings)
            {
                str += $"{topping.Name} ";
            }

            str += $"KES {TotalNetPrice.ToString("0.00")}";

            return str;
        }
    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large,
    }
}
