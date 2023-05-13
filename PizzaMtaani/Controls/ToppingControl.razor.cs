using Microsoft.AspNetCore.Components;
using PizzaMtaani.Components;
using PizzaMtaani.CoreBusiness.Models;

namespace PizzaMtaani.Controls
{
    public partial class ToppingControl : ComponentBase
    {
        [CascadingParameter]
        public PizzaContainer Container { get; set; }

        [Parameter]
        public PizzaTopping? Topping { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            Topping.SelectedSize = Topping?.Prices.FirstOrDefault().Key;
        }

        private void HandleDragStart(PizzaTopping topping)
        {
            Container.PizzaTopping = topping; 
        }
        
    }
}