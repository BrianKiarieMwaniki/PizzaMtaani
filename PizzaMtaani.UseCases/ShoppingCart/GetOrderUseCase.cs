using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.UseCases.ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMtaani.UseCases.ShoppingCart
{
    public class GetOrderUseCase : IGetOrderUseCase
    {
        private readonly IShoppingCart _shoppingCart;

        public GetOrderUseCase(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public async Task<Order> ExecuteAsync()
        {
            return await _shoppingCart.GetOrderAsync();
        }
    }
}
