using System.Runtime.Serialization;

namespace Inventory.Common
{
    [DataContract]
    public class CreateProductCommand 
    {
        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}