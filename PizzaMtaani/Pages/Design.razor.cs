using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Entities;
using PizzaMtaani.CoreBusiness.Models;

namespace PizzaMtaani.Pages
{
    public partial class Design : ComponentBase
    {
        private List<PizzaTopping> Toppings { get; set; } = new();

        private Pizza? _pizza;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            InitializeToppingList();

            _pizza = new Pizza();
            _pizza.Toppings = new List<Topping>();            
        }

        private void HandleOnPizzaToppingAdded()
        {
            StateHasChanged();
        }

        private void InitializeToppingList()
        {
            var cheeseToppings = new PizzaTopping
            {
                Id = new Guid("065ecfc3-4ca7-4d6e-9abb-c3305297a1c2"),
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
                Id = new Guid("b4ecc2f2-ae42-4a01-999d-526faf0645a2"),
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
                Id = new Guid("602d7532-4215-4d7e-a07d-971b0b5ef735"),
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
                Id = new Guid("0fb6bbd4-6296-413d-abcb-efd86654ee71"),
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
                Id = new Guid("58606549-05c2-40ed-ae05-1dfda3a6cb7c"),
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
                Id = new Guid("065ecfc3-4ca7-4d6e-9abb-c3305297a1c2"),
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
                Id = new Guid("3782341a-f2ca-46a0-a87e-9bc04e15ec8a"),
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
                Id = new Guid("5c3f7242-d9dc-482d-b2bb-95fb6459f098"),
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