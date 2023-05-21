using Microsoft.AspNetCore.Components;
using PizzaMtaani.CoreBusiness.Models;

namespace PizzaMtaani.Components.Checkout
{
    public partial class CheckOut : ComponentBase
    {
        [Parameter]
        public Order? Order { get; set; }
    }
}