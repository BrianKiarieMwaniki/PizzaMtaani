namespace PizzaMtaani.UseCases.ShoppingCart.Interfaces
{
    public interface IRemoveOrderItemUseCase
    {
        Task ExecuteAsync(Guid pizzaId);
    }
}