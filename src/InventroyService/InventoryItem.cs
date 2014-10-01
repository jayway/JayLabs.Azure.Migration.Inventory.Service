using System.Runtime.Serialization;

namespace InventroyService
{
    [DataContract]
    public class InventoryItem
    {
        [DataMember]
        public bool  InStock { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}