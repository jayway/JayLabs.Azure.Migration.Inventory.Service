using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InventroyService
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class InventoryService : IInventoryService
    {
        public InventoryItem GetItem(int itemId)
        {
            return new InventoryItem() {InStock = true, Name = "TestItem"};
        }
    }
}
