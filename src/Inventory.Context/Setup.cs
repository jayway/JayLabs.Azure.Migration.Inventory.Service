using System.Data.Entity;
using System.Linq;

namespace Inventory.Context
{
    public class Setup
    {
        public static void Initialize(string connectionName)
        {
           Database.SetInitializer(new CreateDatabaseIfNotExists<InventoryContext>());
            var ctx = new InventoryContext(connectionName);
            //Force DB
            var f = ctx.Products.FirstOrDefault();
        }     
    }
}