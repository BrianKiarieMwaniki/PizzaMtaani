using Microsoft.AspNetCore.Components;
using PizzaMtaani.Models;

namespace PizzaMtaani.Components
{
    public partial class PizzaContainer : ComponentBase
    {
        [Parameter]
        public Pizza Pizza { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<PizzaTopping> OnPizzaToppingAdded { get; set; }

        public EventHandler? OnStateHasChanged { get; set; }


        public PizzaTopping PizzaTopping { get; set; }
      

        public async Task AddPizzaTopping(PizzaTopping topping)
        {
            Pizza.Toppings?.Add(topping);            

            await OnPizzaToppingAdded.InvokeAsync();
        }
    }
}