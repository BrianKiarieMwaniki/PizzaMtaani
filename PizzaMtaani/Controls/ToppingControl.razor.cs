using Microsoft.AspNetCore.Components;
using PizzaMtaani.Components;
using PizzaMtaani.Models;

namespace PizzaMtaani.Controls
{
    public partial class ToppingControl : ComponentBase
    {
        [CascadingParameter]
        public PizzaContainer Container { get; set; }

        [Parameter]
        public PizzaTopping? Topping { get; set; }

        private void HandleDragStart(PizzaTopping topping)
        {
            Container.PizzaTopping = topping;
        }

        private string GetToppingImg(string name)
        {
            if (string.IsNullOrEmpty(name)) return string.Empty;          

            switch(name.ToLower())
            {
                case "cheese":
                    return "images/toppings/cheese.png";                    
                case "pepperoni":
                    return "images/toppings/pepperoni.png";
                case "ham":
                    return "images/toppings/ham.png";
                case "pineapple":
                    return "images/toppings/cheese.png";
                case "sausage":
                    return "images/toppings/sausage.png";
                case "feta cheese":
                    return "images/toppings/fetacheese.png";
                case "tomatoes":
                    return "images/toppings/tomatoes.png";
                case "olives":
                    return "images/toppings/olives.png";

                    default: return string.Empty;
            }
        }
    }
}