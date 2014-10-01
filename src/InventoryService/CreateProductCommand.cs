using System.Runtime.Serialization;

namespace InventroyService
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