using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Inventory.Context;

namespace InventroyService
{
    public class InventoryServiceHost : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            const string connectionName = "InventoryConnection";
            var ctx = Setup.Initialize(connectionName);
            var host = new ServiceHost(new InventoryService(() => new InventoryContext(connectionName)), baseAddresses);
            host.AddServiceEndpoint(typeof(IInventoryService), new WSHttpBinding(), "");
            return host;
        }
    }
}