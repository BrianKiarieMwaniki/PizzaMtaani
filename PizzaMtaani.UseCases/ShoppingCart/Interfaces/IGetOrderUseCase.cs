using PizzaMtaani.CoreBusiness.Models;

namespace PizzaMtaani.UseCases.ShoppingCart.Interfaces
{
    public interface IGetOrderUseCase
    {
        Task<Order> ExecuteAsync();
    }
}