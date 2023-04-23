using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.UseCases.ShoppingCart;

namespace PizzaMtaani.Pages
{
    public partial class PlaceOrder : ComponentBase
    {
        [Inject]
        private IShoppingCart _shoppingCart { get; set; }

        private Order? _order;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            _order = await _shoppingCart.GetOrderAsync();
        }

    }
}