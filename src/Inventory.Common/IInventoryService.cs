using System;
using System.Collections.Generic;

namespace Inventory.Common
{
    public interface IInventoryService
    {
        ProductView GetProduct(Guid itemId);
        IEnumerable<ProductView> GetProducts();

        void Create(CreateProductCommand command);

        void Activate(ActiveProductCommand command);

        void DeActivate(DeActivateCommand command);
    }
}
