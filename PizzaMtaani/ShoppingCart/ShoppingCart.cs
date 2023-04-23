using Microsoft.JSInterop;
using Newtonsoft.Json;
using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.UseCases.ShoppingCart;

namespace PizzaMtaani.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private const string cstrShoppingCart = "cart";

        private readonly IJSRuntime _jSRuntime;

        public ShoppingCart(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }

        public async Task<Order> AddPizzaAsync(Pizza pizza)
        {
            var order = await GetOrder();
            order.AddPizzaToOrder(pizza.Id,pizza,1, pizza.TotalNetPrice);
            await SetOrder(order);

            return order;
        }

        public async Task<Order> DeletePizzaAsync(Guid pizzaId)
        {
            var order = await GetOrder();
            order.RemovePizza(pizzaId);
            await SetOrder(order);

            return order;
        }

        public async Task<Order> GetOrderAsync()
        {
            return await GetOrder();
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            await SetOrder(order);
            return order;
        }

        public async Task<Order> UpdateQuantityAsync(Guid pizzaId, int quantity)
        {
            var order = await GetOrder();
            if (quantity < 0)
            {
                return order;
            }
            else if (quantity == 0)
            {
                return await DeletePizzaAsync(pizzaId);
            }

            var lineItem = order.LineItems.SingleOrDefault(x => x.PizzaId == pizzaId);
            if (lineItem != null) lineItem.Quantity = quantity;
            await SetOrder(order);

            return order;
        }

        private async Task<Order> GetOrder()
        {
            Order order = null;

            var strOrder = await _jSRuntime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);

            if (!string.IsNullOrWhiteSpace(strOrder) && strOrder.ToLower() != "null")
            {
                order = JsonConvert.DeserializeObject<Order>(strOrder);
            }
            else
            {
                order = new Order();
                await SetOrder(order);
            }

            return order;
        }

        private async Task SetOrder(Order order)
        {
            await _jSRuntime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart, JsonConvert.SerializeObject(order));
        }
    }
}
