using System;
using System.Runtime.Serialization;

namespace Inventory.Common
{
    [DataContract]
    public class ActiveProductCommand
    {
        [DataMember]
        public Guid ProductId { get; set; }
    }
}