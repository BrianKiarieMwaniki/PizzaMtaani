﻿using PizzaMtaani.UseCases.ShoppingCart;
using PizzaMtaani.UseCases.StateStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMtaani.StateStore
{
    public class ShoppingCartStateStore : StateStoreBase, IShoppingCartStateStore
    {
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartStateStore(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public async Task<int> GetItemsCount()
        {
            var order = await _shoppingCart.GetOrderAsync();

            if (order != null && order.LineItems != null && order.LineItems.Count > 0)
            {
                return order.LineItems.Count;
            }

            return 0;
        }

        public void UpdateLineItemsCount()
        {
            base.BroadcastStateChange();
        }

        public void UpdateProductQuantity()
        {
            base.BroadcastStateChange();
        }
    }
}
