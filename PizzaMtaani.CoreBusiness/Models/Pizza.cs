using System.ComponentModel.DataAnnotations;

namespace PizzaMtaani.CoreBusiness.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string? Name { get => this.ToString();  }
        public string? Description { get; set; }
        public PizzaSize Size { get; set; } = PizzaSize.Small;
        public List<PizzaTopping>? Toppings { get; set; }

        public decimal Price {get => GetPrice(Size);}

        public decimal TotalNetPrice { get => CalculateNetPrice(); }

        private decimal CalculateNetPrice()
        {
            if (Toppings is null) return Price;

            decimal netPrice = 0;
            foreach (var topping in Toppings)
            {
                netPrice += topping.SelectedPrice;
            }
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


        public override string ToString()
        {
            var str =  $"1 {Size}, {Toppings?.Count} Toppping Pizza - ";

            if(Toppings is null) return str;

            foreach (var topping in Toppings) 
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
