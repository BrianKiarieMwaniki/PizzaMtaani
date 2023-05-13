using System.Diagnostics.CodeAnalysis;

namespace PizzaMtaani.CoreBusiness.Models
{
    public class ToppingIdComparer : IEqualityComparer<Topping>
    {
        public bool Equals(Topping? x, Topping? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Topping obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
