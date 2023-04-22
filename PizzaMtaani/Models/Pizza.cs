namespace PizzaMtaani.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<PizzaTopping>? Toppings { get; set; }

        public decimal Price { get => CalculatePrice(); }

        private decimal CalculatePrice()
        {
            decimal price = 0;

            if (Toppings is null) return price;

            foreach(var topping in Toppings) 
            {
                price += topping.SelectedPrice;
            }

            return Math.Round(price, 2);
        }

    }
}
