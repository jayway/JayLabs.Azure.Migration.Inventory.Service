using System;
using System.Runtime.Serialization;

namespace InventroyService
{
    [DataContract]
    public class ActiveProductCommand
    {
        [DataMember]
        public Guid ProductId { get; set; }
    }
}