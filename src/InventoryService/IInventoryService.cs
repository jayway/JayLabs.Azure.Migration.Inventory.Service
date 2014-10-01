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
        ProductView GetProduct(Guid itemId);

        [OperationContract]
        IEnumerable<ProductView> GetProducts();

        [OperationContract]
        void Create(CreateProductCommand command);

        [OperationContract]
        void Activate(ActiveProductCommand command);

        [OperationContract]
        void DeActivate(DeActivateCommand command);
    }
}
