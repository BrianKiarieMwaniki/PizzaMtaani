using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Entities;
using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.UseCases.ShoppingCart;
using PizzaMtaani.UseCases.StateStore;

namespace PizzaMtaani.Components
{
    public partial class PizzaDesigner : ComponentBase
    {
        [Inject]
        private IShoppingCart _shoppingCart { get; set; }

        [Inject]
        private IShoppingCartStateStore _stateStore { get; set; }

        [CascadingParameter]
        public PizzaContainer Container { get; set; }

        public Pizza? Pizza { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (Container.Pizza != null)
            {
                Pizza = Container.Pizza;
            }
        }

        private async void HandlePizzaAddToCart()
        {
            if (Pizza != null)
            {
                Guid id = Guid.NewGuid();
                Pizza.Id = id;
                await _shoppingCart.AddPizzaAsync(Pizza);

                _stateStore.UpdateLineItemsCount();
            }
        }

        private void HandleQuantityChanged(Topping topping)
        {
            Container.Pizza.UpdateToppingQuantity(topping.Id, topping.Size, "subtract");

            Pizza = Container.Pizza;
        }

        private void HandleClear()
        {
            Container.Pizza.Toppings?.Clear();

        }

        private async Task HandleDrop()
        {
            await Container.OnAddPizzaTopping(Container.PizzaTopping);
        }

        private void HandleDragEnter()
        {

        }

        private void HandleDragLeave()
        {

        }
    }
}