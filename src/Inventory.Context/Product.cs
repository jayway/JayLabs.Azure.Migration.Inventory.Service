using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Context
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
