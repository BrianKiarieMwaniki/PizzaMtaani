using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PizzaMtaani;
using PizzaMtaani.CoreBusiness.Models;
using PizzaMtaani.ShoppingCart;
using PizzaMtaani.StateStore;
using PizzaMtaani.UseCases.ShoppingCart;
using PizzaMtaani.UseCases.ShoppingCart.Interfaces;
using PizzaMtaani.UseCases.StateStore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<PizzaTopping>();
builder.Services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();
builder.Services.AddScoped<IShoppingCart, ShoppingCart>();

builder.Services.AddTransient<IRemoveOrderItemUseCase, RemoveOrderItemUseCase>();
builder.Services.AddTransient<IGetOrderUseCase,  GetOrderUseCase>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
