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
            Setup.Initialize("InventoryConnection");
            var host = new ServiceHost(serviceType, baseAddresses);
            host.AddServiceEndpoint(typeof(IInventoryService), new WSHttpBinding(), "");
            return host;
        }
    }
}