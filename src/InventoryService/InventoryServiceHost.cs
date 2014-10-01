using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Inventory.Common;
using Inventory.Context;
using System.Threading.Tasks;

namespace InventroyService
{
    public class InventoryServiceHost : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            const string connectionName = "InventoryConnection";
            Setup.Initialize(connectionName);

            var host = new ServiceHost(new InventoryService(() => new InventoryContext(connectionName)), baseAddresses);
            host.AddServiceEndpoint(typeof(InventoryService), new WSHttpBinding(), "");
            return host;
        }
    }
}