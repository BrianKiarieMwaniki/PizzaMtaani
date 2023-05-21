using PizzaMtaani.UseCases.ShoppingCart.Interfaces;
using PizzaMtaani.UseCases.StateStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMtaani.UseCases.ShoppingCart
{
    public class RemoveOrderItemUseCase : IRemoveOrderItemUseCase
    {
        private readonly IShoppingCart _shoppingCart;
        private readonly IShoppingCartStateStore _stateStore;

        public RemoveOrderItemUseCase(IShoppingCartStateStore stateStore, IShoppingCart shoppingCart)
        {
            _stateStore = stateStore;
            _shoppingCart = shoppingCart;
        }

        public async Task ExecuteAsync(Guid pizzaId)
        {
            await _shoppingCart.RemovePizzaFromOrder(pizzaId);

            _stateStore.UpdateLineItemsCount();
        }
    }
}
