using PizzaMtaani.CoreBusiness.Entities;
using PizzaMtaani.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMtaani.UseCases.ShoppingCart
{
    public interface IShoppingCart
    {
        Task<Order> GetOrderAsync();
        Task<Order> AddPizzaAsync(Pizza pizza);
        Task<Order> UpdateQuantityAsync(Guid pizzaId, int quantity);
        Task<Order> UpdateOrderAsync(Order order);
        Task<Order> DeletePizzaAsync(Guid pizzaId);
    }
}
