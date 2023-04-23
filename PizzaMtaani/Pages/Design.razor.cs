using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Models;

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
                Id = 1,
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
                Id = 2,
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
                Id = 3,
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
                Id = 4,
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
                Id = 5,
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
                Id = 6,
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
                Id = 7,
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
                Id = 8,
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