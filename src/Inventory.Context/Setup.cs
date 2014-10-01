using System.Data.Entity;
using System.Linq;

namespace Inventory.Context
{
    public class Setup
    {
        public static IInventoryContext Initialize(string connectionName)
        {
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<InventoryContext>());
            var ctx = new InventoryContext(connectionName);
            //Force DB
            var f = ctx.Products.FirstOrDefault();
            return ctx;
        }     
    }
}