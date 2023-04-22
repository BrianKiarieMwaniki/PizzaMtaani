using Microsoft.AspNetCore.Components;
using PizzaMtaani.Models;

namespace PizzaMtaani.Controls
{
    public partial class ToppingControl : ComponentBase
    {
        [Parameter]
        public PizzaTopping? Topping { get; set; }


        private void HandleSizeChange(ChangeEventArgs e)
        {
            var selectedValue = e.Value?.ToString();

            if (selectedValue == string.Empty) return;

            Topping.SelectedSize = selectedValue;

            StateHasChanged();
        }


        private string GetToppingImg(string name)
        {
            if (string.IsNullOrEmpty(name)) return string.Empty;

            //if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";
            //else if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";
            //else if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";
            //else if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";
            //else if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";
            //if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";
            //if (name.Equals("cheese", StringComparison.OrdinalIgnoreCase)) return "images/toppings/cheese.png";

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