using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InventroyService
{
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
        InventoryItem GetItem(int itemId);
    }
}
