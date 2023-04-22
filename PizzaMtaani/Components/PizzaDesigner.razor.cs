using Microsoft.AspNetCore.Components;
using PizzaMtaani.Models;

namespace PizzaMtaani.Components
{
    public partial class PizzaDesigner : ComponentBase
    {
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

        private async Task HandleDrop()
        {
            await Container.AddPizzaTopping(Container.PizzaTopping);
        }     

        private async Task HandleDragEnter()
        {

        }

        private void HandleDragLeave() 
        {
            
        }
    }
}