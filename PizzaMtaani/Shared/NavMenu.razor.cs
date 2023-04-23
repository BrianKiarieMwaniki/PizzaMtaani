using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using PizzaMtaani;
using PizzaMtaani.Shared;
using PizzaMtaani.Controls;
using PizzaMtaani.Components;
using PizzaMtaani.Utils;
using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.UseCases.StateStore;
using PizzaMtaani.StateStore;

namespace PizzaMtaani.Shared
{
    public partial class NavMenu : ComponentBase, IDisposable
    {
        [Inject]
        private IShoppingCartStateStore _stateStore { get; set; }
        private bool collapseNavMenu = true;
        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private int itemsCount = 0;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _stateStore.AddStateChangeListeners(HandleShoppingCartStateChange);
                itemsCount = await _stateStore.GetItemsCount();
                StateHasChanged();
            }
        }

        private async void HandleShoppingCartStateChange()
        {
            itemsCount = await _stateStore.GetItemsCount();
            StateHasChanged();
        }

        public void Dispose()
        {
            _stateStore.RemoveStateChangeListeners(HandleShoppingCartStateChange);
        }

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
        
    }
}