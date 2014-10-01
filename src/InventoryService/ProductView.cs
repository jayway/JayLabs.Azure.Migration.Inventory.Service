using System;
using System.Runtime.Serialization;

namespace InventroyService
{
    [DataContract]
    public class ProductView
    {
        [DataMember]
        public Guid ProductId { get; set; }

        [DataMember]
        public bool  IsActive { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}