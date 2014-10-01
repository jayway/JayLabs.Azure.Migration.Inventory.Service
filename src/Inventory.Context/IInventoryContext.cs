using System.Data.Entity;

namespace Inventory.Context
{
    public interface IInventoryContext
    {
        IDbSet<Product> Products { get; set; }
        int SaveChanges();
    }
}