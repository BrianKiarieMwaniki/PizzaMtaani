namespace PizzaMtaani.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public PizzaSize Size { get; set; } = PizzaSize.Small;
        public List<PizzaTopping>? Toppings { get; set; } 

        private decimal _price;

        public decimal Price 
        { 
            get => GetPrice(Size);
            private set
            {
                _price = value;
            }
        }

        public decimal TotalNetPrice { get => CalculateNetPrice(); }

        private decimal CalculateNetPrice()
        {     
            if (Toppings is null) return Price;

            foreach(var topping in Toppings) 
            {
                Price += topping.SelectedPrice;
            }

            return Math.Round(Price, 2);
        }

        private decimal GetPrice(PizzaSize size)
        {
            switch(size) 
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

    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large,
    }
}
