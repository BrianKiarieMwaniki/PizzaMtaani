using Microsoft.AspNetCore.Components;
using PizzaMtaani.Models;

namespace PizzaMtaani.Pages
{
    public partial class Design : ComponentBase
    {
        private List<PizzaTopping> Toppings { get; set; } = new();

        private Pizza _pizza;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            InitializeToppingList();

            _pizza = new Pizza();
            _pizza.Toppings = new List<PizzaTopping>();
        }

        private void HandleOnPizzaToppingAdded()
        {
            StateHasChanged();
        }

        private void InitializeToppingList()
        {
            var cheeseToppings = new PizzaTopping
            {
                Name = "Cheese",
                IsDeluxe = false,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 50),
                    new KeyValuePair<string, decimal>("Medium", 75),
                    new KeyValuePair<string, decimal>("Large", 100)
                }
            };
            var pepperoniToppings = new PizzaTopping
            {
                Name = "Pepperoni",
                IsDeluxe = false,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 50),
                    new KeyValuePair<string, decimal>("Medium", 75),
                    new KeyValuePair<string, decimal>("Large", 100)
                }
            };
            var hamToppings = new PizzaTopping
            {
                Name = "Ham",
                IsDeluxe = false,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 50),
                    new KeyValuePair<string, decimal>("Medium", 75),
                    new KeyValuePair<string, decimal>("Large", 100)
                }
            };
            var pineappleToppings = new PizzaTopping
            {
                Name = "Pineapple",
                IsDeluxe = false,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 50),
                    new KeyValuePair<string, decimal>("Medium", 75),
                    new KeyValuePair<string, decimal>("Large", 100)
                }
            };
            var sausageToppings = new PizzaTopping
            {
                Name = "Sausage",
                IsDeluxe = true,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 200),
                    new KeyValuePair<string, decimal>("Medium", 300),
                    new KeyValuePair<string, decimal>("Large", 400)
                }
            };
            var fetaCheeseToppings = new PizzaTopping
            {
                Name = "Feta Cheese",
                IsDeluxe = true,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 200),
                    new KeyValuePair<string, decimal>("Medium", 300),
                    new KeyValuePair<string, decimal>("Large", 400)
                }
            };
            var tomatoesToppings = new PizzaTopping
            {
                Name = "Tomatoes",
                IsDeluxe = true,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 200),
                    new KeyValuePair<string, decimal>("Medium", 300),
                    new KeyValuePair<string, decimal>("Large", 400)
                }
            };
            var olivesToppings = new PizzaTopping
            {
                Name = "Olives",
                IsDeluxe = true,
                Prices = new List<KeyValuePair<string, decimal>>
                {
                    new KeyValuePair<string, decimal>("Small", 200),
                    new KeyValuePair<string, decimal>("Medium", 300),
                    new KeyValuePair<string, decimal>("Large", 400)
                }
            };


            Toppings = new List<PizzaTopping>
            {
               cheeseToppings,
                pepperoniToppings,
                hamToppings,
                pineappleToppings,
                sausageToppings,
                fetaCheeseToppings,
                tomatoesToppings,
                olivesToppings
            };
        }
    }
}