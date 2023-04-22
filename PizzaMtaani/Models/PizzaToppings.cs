namespace PizzaMtaani.Models
{
#nullable disable
    public class PizzaTopping
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<KeyValuePair<string, decimal>> Prices { get; set; }
        public bool IsDeluxe { get; set; } = false;

        public string SelectedSize { get; set; } = "Small";

        public decimal SelectedPrice { get => GetSelectedPrice(SelectedSize); }


        private decimal GetSelectedPrice(string size)
        {
            return Prices.Where(p => p.Key.Equals(size, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value;
        }
    }
}