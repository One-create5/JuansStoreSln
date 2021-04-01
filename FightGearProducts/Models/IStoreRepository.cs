using System.Linq;

namespace FightGearProducts.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
