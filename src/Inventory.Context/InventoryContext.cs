using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Context
{
    public class InventoryContext : DbContext, IInventoryContext
    {
        public InventoryContext()
        {
            
        }

        public InventoryContext(string connectionName) : base(connectionName)
        {
                
        }

        public IDbSet<Product> Products { get; set; }
    }
}
