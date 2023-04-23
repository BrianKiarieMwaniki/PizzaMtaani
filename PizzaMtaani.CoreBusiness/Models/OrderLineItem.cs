namespace PizzaMtaani.CoreBusiness.Models
{
    public class OrderLineItem
    {
        public int? LineItemId { get; set; }
        public Guid PizzaId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int? OrderId { get; set; }
        public Pizza Pizza { get; set; }
    }
}