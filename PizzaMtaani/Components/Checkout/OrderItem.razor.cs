using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.UseCases.ShoppingCart;
using PizzaMtaani.UseCases.ShoppingCart.Interfaces;

namespace PizzaMtaani.Components.Checkout
{
    public partial class OrderItem : ComponentBase
    {
        [Inject]
        private IRemoveOrderItemUseCase? _removeOrderItemUseCase { get; set; }

        private bool isProcessing = false;

        [Parameter]
        public OrderLineItem? Item { get; set; }

        private async Task RemoveOrderItem()
        {
            try 
            {
                isProcessing = true;
                await _removeOrderItemUseCase.ExecuteAsync(Item.PizzaId);
            }
            finally
            {
                isProcessing = false;
            }
        }
    }
}