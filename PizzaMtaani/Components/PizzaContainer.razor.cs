using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Entities;
using PizzaMtaani.CoreBusiness.Models;

namespace PizzaMtaani.Components
{
    public partial class PizzaContainer : ComponentBase
    {
        [Parameter]
        public Pizza Pizza { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<PizzaTopping> PizzaToppingAdded { get; set; }

        public EventHandler? OnStateHasChanged { get; set; }


        public PizzaTopping PizzaTopping { get; set; }
      

        public async Task OnAddPizzaTopping(PizzaTopping topping)
        {
            Pizza.AddTopping(topping);          

            await PizzaToppingAdded.InvokeAsync();
        }
    }
}