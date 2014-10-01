using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.Context;

namespace InventroyService
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class InventoryService : IInventoryService
    {
        private IInventoryContext _context;
        private readonly Func<IInventoryContext> _contextFactory;

        private  IInventoryContext Context {
            get { return _context ?? (_context = _contextFactory()); }
        }

        public InventoryService(Func<IInventoryContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }


        public ProductView GetProduct(Guid itemId)
        {
            return
                Context.Products
                    .Select(x => Map(x))
                    .FirstOrDefault(x => x.ProductId == itemId);
        }

        private static ProductView Map(Product product)
        {
            return new ProductView()
            {
                Description = product.Description,
                IsActive = product.IsActive,
                Name = product.Name,
                ProductId = product.Id
            };
        }

        public IEnumerable<ProductView> GetProducts()
        {
            return Context.Products.Select(x => Map(x));
        }

        public void Create(CreateProductCommand command)
        {
            Context.Products.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Description = command.Description,
                IsActive = false,
                Name = command.ProductName
            });
            Context.SaveChanges();
        }

        public void Activate(ActiveProductCommand command)
        {
            var product = Context.Products.FirstOrDefault(x => x.Id == command.ProductId);
            if (product != null) product.IsActive = true;
            Context.SaveChanges();
        }

        public void DeActivate(DeActivateCommand command)
        {
            var product = Context.Products.FirstOrDefault(x => x.Id == command.ProductId);
            if (product != null) product.IsActive = false;
            Context.SaveChanges();
        }
    }
}
